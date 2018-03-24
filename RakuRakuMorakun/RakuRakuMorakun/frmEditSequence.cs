using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RakuRakuMorakun
{
    public partial class frmEditSequence : Form
    {
        private GridController CtpController;
        private Sequence CtpSequence;

        public frmEditSequence(GridController controller, string stName)
        {
            InitializeComponent();
            CtpController = controller;
            CtpSequence = CtpController.GetSequence(stName);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdSet_Click(object sender, EventArgs e)
        {
            long lRowsCount = grdSeqItems.Rows.Count;
            string[] stItems = new string[lRowsCount];

            //グリッドの内容を取り込む
            for (int nRow = 0; nRow < lRowsCount; nRow++)
            {
                stItems[nRow] = (grdSeqItems[0, nRow].Value != null)? grdSeqItems[0, nRow].Value.ToString() : "" ;
            }

            CtpSequence.Items = stItems;
            CtpController.AddSequence(CtpSequence);
            this.Dispose();
        }

        private void frmEditSequence_Load(object sender, EventArgs e)
        {
            //グリッド初期化
            grdSeqItems.Rows.Clear();

            long lTotal = CtpController.Total;
            for (int nRow = 0; nRow < lTotal; nRow++)
            {
                grdSeqItems.Rows.Add();
                grdSeqItems.Rows[nRow].HeaderCell.Value = (nRow + 1).ToString();
                grdSeqItems[0, nRow].Value = CtpSequence.Item(nRow);
            }
        }

        private void grdSeqItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back) //Delete、BackSpace
            {
                //選択されているセルの内容を削除
                foreach (DataGridViewCell cell in grdSeqItems.SelectedCells)
                {
                    cell.Value = null;
                }
            }
            else if (e.KeyCode == Keys.V && e.Control) //Ctr + V（ペースト）
            {
                CtpController.PasteGrid(grdSeqItems, false);
            }
            else if (e.KeyCode == Keys.C && e.Control) //Ctr + C（コピー）
            {
                CtpController.CopyGrid(grdSeqItems);
            }
        }
    }
}
