using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;



namespace CharacterSheet
{ 
    public partial class SpellTome : Form
    {
        public SpellTome()
        {
            InitializeComponent();
        }

        private void SpellTome_Load(object sender, EventArgs e)
        {
            compileSpellList();
            updateCombo();
            Spell firstSpell = SpellList[0];
            showSpellDescriptors(firstSpell);
        }

        

        List<Spell> SpellList = new List<Spell>();

        private void compileSpellList()
        {
            getExcelSpells();
            compileSpellDescriptions();

            for(int i = 0; i < spellDescriptions.Count; i++)
            {
                SpellList[i].Description = spellDescriptions[i];
            }
            
        }


        private void updateCombo()
        {
            cmbTomeSelect.DataSource = SpellList;
            cmbTomeSelect.DisplayMember = "SpellName";
            cmbTomeSelect.ValueMember = "SpellName";
        }

        private void cmbTomeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Spell thisSpell = (Spell)cmbTomeSelect.SelectedItem;
            showSpellDescriptors(thisSpell);
        }

        private void showSpellDescriptors(Spell spell)
        {
            txtSpellDescription.Text = spell.Description;
            lblPageNumber.Text = "Page #: " + spell.Page;
            lblLevel.Text = "Level : " + spell.Level;
            lblSchool.Text = "School: " + spell.School;
            lblCastingTime.Text = spell.CastTime;
            lblRitual.Text = "Ritual :" + spell.Ritual.ToUpper();
            lblVComp.Text = "V : " + spell.VComponent.ToUpper();
            lblSComp.Text = "S : " + spell.SComponent.ToUpper();
            lblMComp.Text = "M : " + spell.MComponent.ToUpper();
            lblConcentration.Text = "Concentration : " + spell.Concentration.ToUpper();
        }



        /**********************************************************
         * 
         * Creating spells in classes.
         * 
         ***********************************************************/

        
        List<string> spellDescriptions = new List<string>();
        
        void getExcelSpells()
        {
            var reader = new StreamReader("ExcelSpells.csv");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(',');                
                Spell newSpell = new Spell(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], "");
                SpellList.Add(newSpell);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void compileSpellDescriptions()
        {
            var reader = new StreamReader("SpellDescriptions.txt");
            StringBuilder sb = new StringBuilder();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split('@');
                string first = values[0].Trim();

                if (first == "NEW")
                {
                    spellDescriptions.Add(sb.ToString());
                    sb.Clear();
                    sb.Append(values[1]);
                    sb.Append(" \r\n ");
                }

                else if (first != "")
                {
                    sb.Append(first);
                    sb.Append(" \r\n ");
                }
            }
           
        }
    }
}
