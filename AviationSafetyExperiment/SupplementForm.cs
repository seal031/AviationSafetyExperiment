using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    public partial class SupplementForm : DevComponents.DotNetBar.Office2007Form
    {
        private ResultSupplement supplement;

        public SupplementForm(string supplementJsonString)
        {
            InitializeComponent();
            try
            {
                supplement = ResultSupplement.fromJson(supplementJsonString);
            }
            catch (Exception ex)
            {
                supplement = null;
            }
        }

        private void SupplementForm_Shown(object sender, EventArgs e)
        {
            if (supplement != null)
            {
                txt_alarmType.Text = supplement.alarmType;
                txt_alarmForm.Text = supplement.alarmForm;
                ii_testCount.Text = supplement.totalTest.ToString();
                ii_alarmCount.Text = supplement.alarmTest.ToString();
                ii_omitCount.Text = supplement.omitCount.ToString();
                ii_misinformationCount.Text = supplement.misinformationCount.ToString();
                ii_usableCount.Text = supplement.usableCount.ToString();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (supplement == null)
            {
                supplement = new Db.Entity.ResultSupplement();
            }
            supplement.alarmType = txt_alarmType.Text.Trim();
            supplement.alarmForm = txt_alarmForm.Text.Trim();
            supplement.totalTest = ii_testCount.Value;
            supplement.alarmTest = ii_alarmCount.Value;
            supplement.omitCount = ii_omitCount.Value;
            supplement.misinformationCount = ii_misinformationCount.Value;
            supplement.usableCount = ii_usableCount.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string getSupplimentJsonString()
        {
            if (supplement == null)
            { return string.Empty; }
            else
            {
                return supplement.toJson();
            }
        }
    }
}
