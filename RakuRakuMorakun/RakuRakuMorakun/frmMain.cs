using System;
using System.Windows.Controls;
using System.Windows.Forms;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{
    public partial class frmMain : Form
    {
        
        private GridController controller;
        frmPreview frmPreview;
        private bool CblCellEditingFlag = false; 

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            controller = new GridController();
            controller.SetDataToGrid(grdMain);
            lblCount.Text = string.Format(TEXT_FORMAT_TOTAL_COUNT, controller.Total);
            frmPreview = new frmPreview(this);

            //セルの内容に合わせて、行の高さが自動的に調節されるようにする
            grdCondition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //テキストを折り返して表示する
            grdCondition.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grdCondition.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grdCondition.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        //空白をグレーアウト
        private void cmdAllGrayOut_Click(object sender, EventArgs e)
        {
            controller.InvalidEmptyCell(grdMain);
            //更新
            UpdateGridData();
            UpdatePreview();
        }

        //列追加ボタン
        private void cmdAddColumn_Click(object sender, EventArgs e)
        {
            controller.AddColumn(grdMain);
            //更新
            UpdateGridData();
            UpdatePreview();
        }

        private void cmdDeleteColumn_Click(object sender, EventArgs e)
        {
            controller.DeleteColumn(grdMain);
            //更新
            UpdateGridData();
            UpdatePreview();
        }

        private void cmdValid_Click(object sender, EventArgs e)
        {
            controller.ValidCells(grdMain);
            //更新
            UpdateGridData();
            UpdatePreview();
        }

        private void cmdInvalid_Click(object sender, EventArgs e)
        {
            controller.InvalidCells(grdMain);
            //更新
            UpdateGridData();
            UpdatePreview();
        }

        public bool PreviewChecked{
            set { chkPreview.Checked = value; }
            get { return chkPreview.Checked; }
        }

        //開始ボタン
        private void cmdStart_Click(object sender, EventArgs e)
        {
            chkPreview.Checked = true;
            //全件取得&クリップボードにコピー
            UpdatePreview(0,true);
            MessageBox.Show("クリップボードにコピーしました");
        }

        //テンプレートが編集されたらリアルタイムでプレビューする
        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        //プレビュー表示チェックボックス
        private void chkPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPreview.Checked)
            {
                frmPreview.Show();
                UpdatePreview();
            }
            else
            {
                frmPreview.Dispose();
                frmPreview = new frmPreview(this);
            }
        }


        //条件付き文字列の追加
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //新規で追加のときは新しく付番
            string stName = controller.GetNextConditionName();
            frmEditCondition frmC = new frmEditCondition(controller, stName);
            frmC.ShowDialog();

            //グリッドに反映する
            controller.SetConditionToGrid(grdCondition);

            //更新
            UpdateGridData();
        }


        //ダブルクリックは編集
        private void grdCondition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string stName =grdCondition[0, e.RowIndex].Value.ToString();

            frmEditCondition frmC = new frmEditCondition(controller, stName);
            frmC.ShowDialog();

            //グリッドに反映する
            controller.SetConditionToGrid(grdCondition);
        }

        //条件付き文字列の削除
        private void cmdDeleteCondition_Click(object sender, EventArgs e)
        {
            string stName = "";

            foreach (DataGridViewRow row in grdCondition.SelectedRows)
            {
                stName = grdCondition[0, row.Index].Value.ToString();
                break;
            }

            if (stName == "") { return; }

            controller.DeleteCondition(stName);

            //グリッドに反映する
            controller.SetConditionToGrid(grdCondition);
        }

        //セルがクリックされたら内容を表示
        private void grdMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCellText(e.ColumnIndex, e.RowIndex);
        }

        //セルがフォーカスされたら内容を表示
        private void grdMain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SetCellText(e.ColumnIndex, e.RowIndex);
        }

        //セルの内容をテキストボックスに出力
        private void SetCellText(int nCol, int nRow)
        {
            if(nCol < 0 || nRow < 0){ return; }
            txtCellText.Text = (grdMain[nCol, nRow].Value != null) ? grdMain[nCol, nRow].Value.ToString() : "";
        }

        //セルが編集モードになったとき最初に呼ばれる
        private void grdMain_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        //CellBeginEditの次に呼ばれる
        private void grdMain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            //表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                DataGridView dgv = (DataGridView)sender;

                //編集のために表示されているコントロールを取得
                DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;

                ////イベントハンドラを削除
                tb.TextChanged -= new EventHandler(Cell_TextChanged);

                //イベントハンドラを追加
                tb.TextChanged += new EventHandler(Cell_TextChanged);
            }
        }

        private void Cell_TextChanged(object sender, EventArgs e)
        {
            CblCellEditingFlag = true;
            txtCellText.Text = ((DataGridViewTextBoxEditingControl)sender).Text;
        }

        private void txtCellText_TextChanged(object sender, EventArgs e)
        {
            //セルとテキストボックスが互いに書き込み合わないように制御
            if (CblCellEditingFlag) { return; }

            //選択されているセルを取得
            foreach (DataGridViewCell cell in grdMain.SelectedCells)
            {
                cell.Value = txtCellText.Text;
                return;
            }
        }

        //セルの編集が終わったときは更新
        private void grdMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CblCellEditingFlag = false;
            SetCellText(e.ColumnIndex, e.RowIndex);
            //更新
            UpdateGridData();
            UpdatePreview();
        }

        private void UpdateGridData()
        {
            //グリッドの情報を取り込む
            controller.GetDataFromGrid(grdMain);
            //キャプション更新
            lblCount.Text = string.Format(TEXT_FORMAT_TOTAL_COUNT, controller.Total);
        }

        //プレビュー更新
        private void UpdatePreview(int nGetCount = 5, bool blClipboardCopyFlag = false)
        {
            if (!frmPreview.Visible) { return; }

            string[] stResultArr;
            stResultArr = controller.CreateResultArr(grdMain, txtTemplate.Text, nGetCount);
            string stResult = string.Join("\r\n", stResultArr);
            frmPreview.PreviewText = stResult;

            if (blClipboardCopyFlag) { Clipboard.SetText(stResult); }
        }


        //ショートカットキーなど
        private void grdMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back) //Delete、BackSpace
            {
                //選択されているセルの内容を削除
                foreach (DataGridViewCell cell in grdMain.SelectedCells)
                {
                    cell.Value = null;
                }
            }
            else if (e.KeyCode == Keys.V && e.Control) //Ctr + V（ペースト）
            {
                controller.PasteGrid(grdMain);
            }
            else if (e.KeyCode == Keys.C && e.Control) //Ctr + C（コピー）
            {
                controller.CopyGrid(grdMain);
            }
        }

        //列を左と交換
        private void cmdMoveLeft_Click(object sender, EventArgs e)
        {
            controller.MoveColumn(grdMain, -1);
            UpdateGridData();
        }

        //列を右と交換
        private void cmdMoveRight_Click(object sender, EventArgs e)
        {
            controller.MoveColumn(grdMain, 1);
            UpdateGridData();
        }

        //行が追加されたとき
        private void grdMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //controller.InvalidNewRow(grdMain);
        }
    }
}
