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
            UpdateForm();
        }

        //列追加ボタン
        private void cmdAddColumn_Click(object sender, EventArgs e)
        {
            controller.AddColumn(grdMain);
            //更新
            UpdateForm();
        }

        private void cmdDeleteColumn_Click(object sender, EventArgs e)
        {
            controller.DeleteColumn(grdMain);
            //更新
            UpdateForm();
        }

        private void cmdValid_Click(object sender, EventArgs e)
        {
            controller.ValidCells(grdMain);
            //更新
            UpdateForm();
        }

        private void cmdInvalid_Click(object sender, EventArgs e)
        {
            controller.InvalidCells(grdMain);
            //更新
            UpdateForm();
        }

        public bool PreviewChecked{
            set { chkPreview.Checked = value; }
            get { return chkPreview.Checked; }
        }

        //開始ボタン
        private void cmdStart_Click(object sender, EventArgs e)
        {
            string[] stResult;
            stResult = controller.CreateResultArr(grdMain, txtTemplate.Text);
            frmPreview.PreviewText = string.Join("\r\n", stResult);
            
        }

        //テンプレートが編集されたらリアルタイムでプレビューする
        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            string[] stResult;
            stResult = controller.CreateResultArr(grdMain, txtTemplate.Text, 3);
            frmPreview.PreviewText = string.Join("\r\n", stResult);
        }

        private void chkPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPreview.Checked)
            {
                string[] stResult;
                stResult = controller.CreateResultArr(grdMain, txtTemplate.Text, 3);

                frmPreview.PreviewText = string.Join("\r\n", stResult);
                frmPreview.Show();
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
            UpdateForm();
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

        
        private void cmdAllEnabled_Click(object sender, EventArgs e)
        {
            controller.ValidNotEmptyCell(grdMain);
            //更新
            UpdateForm();
        }

        //全て有効化
        private void cmdValidAll_Click(object sender, EventArgs e)
        {
            controller.ValidAllCell(grdMain);
            //更新
            UpdateForm();
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
            if (grdMain[nCol,nRow].Value != null)
            {
                txtCellText.Text = grdMain[nCol, nRow].Value.ToString();
            }
            else
            {
                txtCellText.Text = "";
            }
        }

        //セルが編集モードになったとき最初に呼ばれる
        private void grdMain_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            grdMain[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.White;
        }

        //CellBeginEditの次に呼ばれる
        private void grdMain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CblCellEditingFlag = true;

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
            txtCellText.Text = ((DataGridViewTextBoxEditingControl)sender).EditingControlFormattedValue.ToString();
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
            UpdateForm();
        }


        private void UpdateForm()
        {
            //グリッドの情報を取り込む
            controller.GetDataFromGrid(grdMain);
            //キャプション更新
            lblCount.Text = string.Format(TEXT_FORMAT_TOTAL_COUNT, controller.Total);
            //プレビュー更新
            string[] stResult;
            stResult = controller.CreateResultArr(grdMain, txtTemplate.Text, 3);
            frmPreview.PreviewText = string.Join("\r\n", stResult);
        }

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
            else if (e.KeyCode == Keys.V && e.Control) //Ctr + V
            {
                controller.PasteGrid(grdMain);
            }

        }
    }
}
