using System;
using System.Collections.Generic;
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
    public partial class frmCharacterSheet : Form
    {
        public frmCharacterSheet()
        {
            InitializeComponent();
        }

        /****************************
         * The following are text changed methods for the 6 primary stats
         * found in the main stat group. They employ a method resetAllSCores(),
         * that resets many of the scores in the form.
         */
        private void txtStr_TextChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void txtDex_TextChanged(object sender, EventArgs e)
        {
            resetAllScores();
            //Armor class and Initiative are reset by the following two functions
            changeInitiative();
            resetAC();
        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {
            resetAllScores();
            //reseting armor class
            resetAC();
        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void txtWis_TextChanged_1(object sender, EventArgs e)
        {
            resetAllScores();
            //reseting armor class and passive perception
            changePassivePerception();
            resetAC();
        }

        private void txtCha_TextChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        /******************
         * The folling reset<mod>scores() methods reset their scores to zero,
         * then reads all of the checked checkboxes using the checkChecked() method.
         * after the skill scores check boxes have been added, makeMod() is used to 
         * generate the modification for the Main Stat. It is then added to the scores as well.
         * There are 6, for each of the main stats. ModAdd() is used to create the final scores.
         */

        //Strength
        private void resetStrScores()
        {
            string zero = "0";
            lblAthleticsScore.Text = zero;

            lblAthleticsScore.Text = checkChecked(chkAthleticsExp.Checked, lblAthleticsScore.Text);
            lblAthleticsScore.Text = checkChecked(chkAthleticsProf.Checked, lblAthleticsScore.Text);

            string mod = Convert.ToString(makeMod(txtStr.Text));
            lblStrMod.Text = mod;
            lblAthleticsScore.Text = modAdd(lblAthleticsScore.Text, mod);
        }
        
        //Dexterity
        private void resetDexScores()
        {
            string zero = "0";
            lblAcrobaticsScore.Text = zero;
            lblSleightOfHandScore.Text = zero;
            lblStealthScore.Text = zero;

            lblAcrobaticsScore.Text = checkChecked(chkAcrobaticsProf.Checked, lblAcrobaticsScore.Text);
            lblAcrobaticsScore.Text = checkChecked(chkAcrobaticsExp.Checked, lblAcrobaticsScore.Text);

            lblSleightOfHandScore.Text = checkChecked(chkSleightOfHandProf.Checked, lblSleightOfHandScore.Text);
            lblSleightOfHandScore.Text = checkChecked(chkSleightOfHandExp.Checked, lblSleightOfHandScore.Text);

            lblStealthScore.Text = checkChecked(chkStealthProf.Checked, lblStealthScore.Text);
            lblStealthScore.Text = checkChecked(chkStealthExp.Checked, lblStealthScore.Text);

            string mod = Convert.ToString(makeMod(txtDex.Text));
            lblDexMod.Text = mod;
            lblAcrobaticsScore.Text = modAdd(lblAcrobaticsScore.Text, mod);
            lblSleightOfHandScore.Text = modAdd(lblSleightOfHandScore.Text, mod);
            lblStealthScore.Text = modAdd(lblStealthScore.Text, mod);
        }

        //Constitution
        private void resetConScores()
        {
            string mod = Convert.ToString(makeMod(txtCon.Text));
            lblConMod.Text = mod;
        }

        //Intelligence
        private void resetIntScores()
        {
            string zero = "0";
            lblArcanaScore.Text = zero;
            lblHistoryScore.Text = zero;
            lblInvestigationScore.Text = zero;
            lblNatureScore.Text = zero;
            lblReligionScore.Text = zero;

            lblArcanaScore.Text = checkChecked(chkArcanaProf.Checked, lblArcanaScore.Text);
            lblArcanaScore.Text = checkChecked(chkArcanaExp.Checked, lblArcanaScore.Text);

            lblHistoryScore.Text = checkChecked(chkHistoryProf.Checked, lblHistoryScore.Text);
            lblHistoryScore.Text = checkChecked(chkHistoryExp.Checked, lblHistoryScore.Text);

            lblInvestigationScore.Text = checkChecked(chkInvestigationProf.Checked, lblInvestigationScore.Text);
            lblInvestigationScore.Text = checkChecked(chkInvestigationExp.Checked, lblInvestigationScore.Text);

            lblNatureScore.Text = checkChecked(chkNatureProf.Checked, lblNatureScore.Text);
            lblNatureScore.Text = checkChecked(chkNatureExp.Checked, lblNatureScore.Text);

            lblReligionScore.Text = checkChecked(chkReligionProf.Checked, lblReligionScore.Text);
            lblReligionScore.Text = checkChecked(chkReligionExp.Checked, lblReligionScore.Text);

            string mod = Convert.ToString(makeMod(txtInt.Text));
            lblIntMod.Text = mod;
            lblArcanaScore.Text = modAdd(lblArcanaScore.Text, mod);
            lblHistoryScore.Text = modAdd(lblHistoryScore.Text, mod);
            lblInvestigationScore.Text = modAdd(lblInvestigationScore.Text, mod);
            lblNatureScore.Text = modAdd(lblNatureScore.Text, mod);
            lblReligionScore.Text = modAdd(lblReligionScore.Text, mod);

        }

        //Wisdom
        private void resetWisScores()
        {
            string zero = "0";
            lblAnimalHandScore.Text = zero;
            lblInsightScore.Text = zero;
            lblMedicineScore.Text = zero;
            lblPerceptionScore.Text = zero;
            lblSurvivalScore.Text = zero;

            lblAnimalHandScore.Text = checkChecked(chkAnimalHandProf.Checked, lblAnimalHandScore.Text);
            lblAnimalHandScore.Text = checkChecked(chkAnimalHandExp.Checked, lblAnimalHandScore.Text);

            lblInsightScore.Text = checkChecked(chkInsightProf.Checked, lblInsightScore.Text);
            lblInsightScore.Text = checkChecked(chkInsightExp.Checked, lblInsightScore.Text);

            lblMedicineScore.Text = checkChecked(chkMedicineProf.Checked, lblMedicineScore.Text);
            lblMedicineScore.Text = checkChecked(chkMedicineExp.Checked, lblMedicineScore.Text);

            lblPerceptionScore.Text = checkChecked(chkPerceptionProf.Checked, lblPerceptionScore.Text);
            lblPerceptionScore.Text = checkChecked(chkPerceptionExp.Checked, lblPerceptionScore.Text);

            lblSurvivalScore.Text = checkChecked(chkSurvivalProf.Checked, lblSurvivalScore.Text);
            lblSurvivalScore.Text = checkChecked(chkSurvivalExp.Checked, lblSurvivalScore.Text);

            string mod = Convert.ToString(makeMod(txtWis.Text));
            lblWisMod.Text = mod;
            lblAnimalHandScore.Text = modAdd(lblAnimalHandScore.Text, mod);
            lblInsightScore.Text = modAdd(lblInsightScore.Text, mod);
            lblMedicineScore.Text = modAdd(lblMedicineScore.Text, mod);
            lblPerceptionScore.Text = modAdd(lblPerceptionScore.Text, mod);
            lblSurvivalScore.Text = modAdd(lblSurvivalScore.Text, mod);
        }

        //Charisma
        private void resetChaScores()
        {
            string zero = "0";
            lblDeceptionScore.Text = zero;
            lblIntimidationScore.Text = zero;
            lblPerformanceScore.Text = zero;
            lblPersuasionScore.Text = zero;

            lblDeceptionScore.Text = checkChecked(chkDeceptionProf.Checked, lblDeceptionScore.Text);
            lblDeceptionScore.Text = checkChecked(chkDeceptionExp.Checked, lblDeceptionScore.Text);

            lblIntimidationScore.Text = checkChecked(chkIntimidationProf.Checked, lblIntimidationScore.Text);
            lblIntimidationScore.Text = checkChecked(chkIntimidationExp.Checked, lblIntimidationScore.Text);

            lblPerformanceScore.Text = checkChecked(chkPerformanceProf.Checked, lblPerformanceScore.Text);
            lblPerformanceScore.Text = checkChecked(chkPerformanceExp.Checked, lblPerformanceScore.Text);

            lblPersuasionScore.Text = checkChecked(chkPersuasionProf.Checked, lblPersuasionScore.Text);
            lblPersuasionScore.Text = checkChecked(chkPersuasionExp.Checked, lblPersuasionScore.Text);

            string mod = Convert.ToString(makeMod(txtCha.Text));
            lblChaMod.Text = mod;
            lblDeceptionScore.Text = modAdd(lblDeceptionScore.Text, mod);
            lblIntimidationScore.Text = modAdd(lblIntimidationScore.Text, mod);
            lblPerformanceScore.Text = modAdd(lblPerformanceScore.Text, mod);
            lblPersuasionScore.Text = modAdd(lblPersuasionScore.Text, mod);
        }

        //This function uses modAdd() to create the Passive Perception score
        private void changePassivePerception()
        {
            lblPassivePerc.Text = modAdd("10", lblPerceptionScore.Text);
        }

        /**********
         * resetAllScores employs all of the Main stat reset methods.
         * It then also uses jackAdd() to add half of the proficiency
         * score to all skills, if checked.
         * Change DCSave() will also update the spell dc score.
         */
        private void resetAllScores()
        {
            resetStrScores();
            resetDexScores();
            resetIntScores();
            resetChaScores();
            resetWisScores();
            resetConScores();
            jackAdd(chkJackOfAll.Checked);
            changeDCSave();
        }

        //Make Mod uses int.TryParse to determine if the text can 
        //be parsed, If so, it makes the number even (a way of rounding down)
        //and divides it by two, creating the modification for the dice roll.
        //else it return 0
        public int makeMod(string txtBox)
        {
            int stat;
            bool result = int.TryParse(txtBox, out stat);
            if (result == true)
            {
                if (stat % 2 != 0)
                {
                    stat = stat - 1;
                }
                int mod = (stat - 10) / 2;
                return mod;
            }
            else
            {
                return 0;
            }
        }

        //When the experience text box is changed, determinLevel(), and 
        //determineProficiency are used to find the characters level and 
        //proficiency score, which much is based off of. 
        //These lables are set, and resetAllScores() is used. 
        private void txtExperience_TextChanged(object sender, EventArgs e)
        {

            lblLevelRank.Text = determineLevel(txtExperience.Text);
            lblProfBonus.Text = determineProficiency(lblLevelRank.Text);
            resetAllScores();
        }

        /**********
         * determineProficiency finds the proficiency based 
         * off of DnD charts provided in the game.
         * This is determined by using else if. The lowest 
         * score possible is 2, so it is the defalt return.
         */
        public string determineProficiency(string txt)
        {
            int num = Convert.ToInt32(txt);
            string prof;
            if (num < 5)
            {
                prof = "2";
                return prof;

            }
            else if (num >= 5 && num < 9)
            {
                prof = "3";
                return prof;

            }
            else if (num >= 9 && num < 13)
            {
                prof = "4";
                return prof;

            }
            else if (num >= 13 && num < 17)
            {
                prof = "5";
                return prof;

            }
            else if (num >= 17)
            {
                prof = "6";
                return prof;
            }

            else { return "2"; }
            
        }

        /**************************
         * this method is very similar to determineProficiency. The main
         * difference being this is the function that parses the experience text box,
         * it then determines the level using else if, with scores from DnD.
         */
        public string determineLevel(string txt)
        {
            int num;
            string level;
            bool result = int.TryParse(txt, out num);
            if (result == true)
            {
                if (num < 300)
                {
                    level = "1";
                    return level;

                }
                else if (num >= 300 && num < 900)
                {
                    level = "2";
                    return level;

                }
                else if (num >= 900 && num < 2700)
                {
                    level = "3";
                    return level;

                }
                else if (num >= 2700 && num < 6500)
                {
                    level = "4";
                    return level;

                }
                else if (num >= 6500 && num < 14000)
                {
                    level = "5";
                    return level;

                }
                else if (num >= 14000 && num < 23000)
                {
                    level = "6";
                    return level;

                }
                else if (num >= 23000 && num < 34000)
                {
                    level = "7";
                    return level;

                }
                else if (num >= 34000 && num < 48000)
                {
                    level = "8";
                    return level;

                }
                else if (num >= 48000 && num < 64000)
                {
                    level = "9";
                    return level;

                }
                else if (num >= 64000 && num < 85000)
                {
                    level = "10";
                    return level;

                }
                else if (num >= 85000 && num < 100000)
                {
                    level = "11";
                    return level;

                }
                else if (num >= 100000 && num < 120000)
                {
                    level = "12";
                    return level;

                }
                else if (num >= 120000 && num < 140000)
                {
                    level = "13";
                    return level;

                }
                else if (num >= 140000 && num < 165000)
                {
                    level = "14";
                    return level;

                }
                else if (num >= 165000 && num < 195000)
                {
                    level = "15";
                    return level;

                }
                else if (num >= 195000 && num < 225000)
                {
                    level = "16";
                    return level;

                }
                else if (num >= 225000 && num < 265000)
                {
                    level = "17";
                    return level;

                }
                else if (num >= 265000 && num < 305000)
                {
                    level = "18";
                    return level;

                }
                else if (num >= 305000 && num < 355000)
                {
                    level = "19";
                    return level;

                }
                else if (num >= 355000)
                {
                    level = "20";
                    return level;

                }
            }
            level = "0";
            return level;
        }

        /*************
         * modAdd is basically and addition function for strings
         * containing integers. Since this program deals with strings,
         * creating an addition method seemed appropriate.
         */
        private string modAdd(string ability, string prof)
        {
            int i = Convert.ToInt32(ability);
            int j = Convert.ToInt32(prof);
            j = i + j;
            string k = Convert.ToString(j);
            return k;
        }

        //This is identical to modAdd(), the difference being a subtract
        //instead of addition
        private string modSubtract(string ability, string prof)
        {
            int i = Convert.ToInt32(ability);
            int j = Convert.ToInt32(prof);
            j = i - j;
            string k = Convert.ToString(j);
            return k;
        }

        /***************
         * This was created for checkboxes. It takes in a score label
         * and boolean for a check box. If the check box is checked
         * it adds the proficiency bonus, if not it passes back its
         * original value, so this can be used in a row many times
         * for score reseting. 
         */
        private string checkChecked(bool check, string txt)
        {
            string lbl;
            if (check)
            {
                lbl = modAdd(txt, lblProfBonus.Text);
                return lbl;
            }
            else
            {
                return txt;
            }
        }

        /*******************
         * this creates the number added by clicking the jack of all trades box.
         * it divides the proficiency score lable by 2 and rounds down, return the 
         * bonus as a string.
         */
        private string createJackMod()
        {
            int jackmod = Convert.ToInt32(lblProfBonus.Text);

            if (jackmod % 2 != 0)
            {
                jackmod = (jackmod - 1) / 2;
            }
            else
            {
                jackmod = jackmod / 2;
            }

            string jack = Convert.ToString(jackmod);
            return jack;
        }

        /*******************
         * This is for adding the jack of all trades modifier to the 
         * skill scores. By the rules of the game, jack of all trades 
         * can't be applied to skill in which the character is proficient 
         * or has expertise. So jack add checks to see if either are checked
         * for each skill, if not, then it uses modAdd to add the "jackMod" 
         * created by createJackMod();
         */
        private void jackAdd(bool check)
        {
            string jack = createJackMod();

            if (check)
            {
                if ( !(chkAcrobaticsProf.Checked || chkAcrobaticsExp.Checked))
                {
                    lblAcrobaticsScore.Text = modAdd(lblAcrobaticsScore.Text, jack);

                }
                if (!(chkAnimalHandProf.Checked || chkAnimalHandExp.Checked))
                {
                    lblAnimalHandScore.Text = modAdd(lblAnimalHandScore.Text, jack);

                }
                if (!(chkArcanaProf.Checked || chkArcanaExp.Checked))
                {
                    lblArcanaScore.Text = modAdd(lblArcanaScore.Text, jack);
                }
                if (!(chkAthleticsProf.Checked || chkAthleticsExp.Checked))
                {
                    lblAthleticsScore.Text = modAdd(lblAthleticsScore.Text, jack);
                
                }
                if (!(chkDeceptionProf.Checked || chkDeceptionExp.Checked))
                {
                    lblDeceptionScore.Text = modAdd(lblDeceptionScore.Text, jack);
                
                }
                if (!(chkHistoryExp.Checked || chkHistoryProf.Checked))
                {
                    lblHistoryScore.Text = modAdd(lblHistoryScore.Text, jack);
                
                }
                if (!(chkInsightProf.Checked || chkInsightExp.Checked))
                {
                    lblInsightScore.Text = modAdd(lblInsightScore.Text, jack);
                
                }
                if (!(chkIntimidationProf.Checked || chkIntimidationExp.Checked))
                {
                    lblIntimidationScore.Text = modAdd(lblIntimidationScore.Text, jack);
                
                }
                if (!(chkInvestigationProf.Checked || chkInvestigationExp.Checked))
                {
                    lblInvestigationScore.Text = modAdd(lblInvestigationScore.Text, jack);
                
                }
                if (!(chkMedicineProf.Checked || chkMedicineExp.Checked))
                {
                    lblMedicineScore.Text = modAdd(lblMedicineScore.Text, jack);
                
                }
                if (!(chkNatureProf.Checked || chkNatureExp.Checked))
                {
                    lblNatureScore.Text = modAdd(lblNatureScore.Text, jack);
                
                }
                if (!(chkPerceptionProf.Checked || chkPerceptionExp.Checked))
                {                    
                    lblPerceptionScore.Text = modAdd(lblPerceptionScore.Text, jack);
                
                }
                if (!(chkPerformanceProf.Checked || chkPerformanceExp.Checked))
                {
                    lblPerformanceScore.Text = modAdd(lblPerformanceScore.Text, jack);
                
                }
                if (!(chkPersuasionProf.Checked || chkPersuasionExp.Checked))
                {
                    lblPersuasionScore.Text = modAdd(lblPersuasionScore.Text, jack);
                
                }
                if (!(chkReligionProf.Checked || chkReligionExp.Checked))
                {
                    lblReligionScore.Text = modAdd(lblReligionScore.Text, jack);
                
                }
                if (!(chkSleightOfHandProf.Checked || chkSleightOfHandExp.Checked))
                {
                    lblSleightOfHandScore.Text = modAdd(lblSleightOfHandScore.Text, jack);
                
                }
                if (!(chkStealthProf.Checked || chkStealthExp.Checked))
                {
                    lblStealthScore.Text = modAdd(lblStealthScore.Text, jack);
                
                }
                if (!(chkSurvivalProf.Checked || chkSurvivalExp.Checked))
                {
                    lblSurvivalScore.Text = modAdd(lblSurvivalScore.Text, jack);
                
                }
            }
            //reseting passive perception, because it is affected by jack of all trades.
            changePassivePerception();
        }

        /***********
         * Exactly the same as JackAdd(), except it subtracts
         */
        private void jackSubtract(bool check)
        {
            string jack = createJackMod();

            if (!(check))
            {
                if ( !(chkAcrobaticsProf.Checked || chkAcrobaticsExp.Checked))
                {
                    lblAcrobaticsScore.Text = modSubtract(lblAcrobaticsScore.Text, jack);

                }
                if (!(chkAnimalHandProf.Checked || chkAnimalHandExp.Checked))
                {
                    lblAnimalHandScore.Text = modSubtract(lblAnimalHandScore.Text, jack);

                }
                if (!(chkArcanaProf.Checked || chkArcanaExp.Checked))
                {
                    lblArcanaScore.Text = modSubtract(lblArcanaScore.Text, jack);
                }
                if (!(chkAthleticsProf.Checked || chkAthleticsExp.Checked))
                {
                    lblAthleticsScore.Text = modSubtract(lblAthleticsScore.Text, jack);
                
                }
                if (!(chkDeceptionProf.Checked || chkDeceptionExp.Checked))
                {
                    lblDeceptionScore.Text = modSubtract(lblDeceptionScore.Text, jack);
                
                }
                if (!(chkHistoryExp.Checked || chkHistoryProf.Checked))
                {
                    lblHistoryScore.Text = modSubtract(lblHistoryScore.Text, jack);
                
                }
                if (!(chkInsightProf.Checked || chkInsightExp.Checked))
                {
                    lblInsightScore.Text = modSubtract(lblInsightScore.Text, jack);
                
                }
                if (!(chkIntimidationProf.Checked || chkIntimidationExp.Checked))
                {
                    lblIntimidationScore.Text = modSubtract(lblIntimidationScore.Text, jack);
                
                }
                if (!(chkInvestigationProf.Checked || chkInvestigationExp.Checked))
                {
                    lblInvestigationScore.Text = modSubtract(lblInvestigationScore.Text, jack);
                
                }
                if (!(chkMedicineProf.Checked || chkMedicineExp.Checked))
                {
                    lblMedicineScore.Text = modSubtract(lblMedicineScore.Text, jack);
                
                }
                if (!(chkNatureProf.Checked || chkNatureExp.Checked))
                {
                    lblNatureScore.Text = modSubtract(lblNatureScore.Text, jack);
                
                }
                if (!(chkPerceptionProf.Checked || chkPerceptionExp.Checked))
                {                    
                    lblPerceptionScore.Text = modSubtract(lblPerceptionScore.Text, jack);
                
                }
                if (!(chkPerformanceProf.Checked || chkPerformanceExp.Checked))
                {
                    lblPerformanceScore.Text = modSubtract(lblPerformanceScore.Text, jack);
                
                }
                if (!(chkPersuasionProf.Checked || chkPersuasionExp.Checked))
                {
                    lblPersuasionScore.Text = modSubtract(lblPersuasionScore.Text, jack);
                
                }
                if (!(chkReligionProf.Checked || chkReligionExp.Checked))
                {
                    lblReligionScore.Text = modSubtract(lblReligionScore.Text, jack);
                
                }
                if (!(chkSleightOfHandProf.Checked || chkSleightOfHandExp.Checked))
                {
                    lblSleightOfHandScore.Text = modSubtract(lblSleightOfHandScore.Text, jack);
                
                }
                if (!(chkStealthProf.Checked || chkStealthExp.Checked))
                {
                    lblStealthScore.Text = modSubtract(lblStealthScore.Text, jack);
                
                }
                if (!(chkSurvivalProf.Checked || chkSurvivalExp.Checked))
                {
                    lblSurvivalScore.Text = modSubtract(lblSurvivalScore.Text, jack);
                
                }
            }
            //Changing passive perception
            changePassivePerception();
        }

        //everytime jack of all trades is checked, this runs jackAdd() and jackSubtract to determine skill scores
        private void jackCheckUncheck(bool check)
        {
            jackAdd(check);
            jackSubtract(check);
        }

        /***************************
         * The next block of code is for everycheck box, and its check changed event.
         * when any of the boxes are changed all scores are reset using resetAllSCores();
         */
        private void chkAcrobaticsProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkAnimalHandProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkArcanaProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkAthleticsProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkDeceptionProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkHistoryProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkInsightProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkIntimidationProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkInvestigationProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkMedicineProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkNatureProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkPerceptionProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
            //Passive perception is affected by this box, so changePassivePerception is employed
            changePassivePerception();
        }

        private void chkPersuasionProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkPerformanceProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkReligionProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkSleightOfHandProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkStealthProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkSurvivalProf_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkAcrobaticsExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkAnimalHandExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkArcanaExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkAthleticsExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkDeceptionExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkHistoryExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkInsightExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkIntimidationExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkInvestigationExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkMedicineExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkNatureExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkPerceptionExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
            //Passive perception is affected by this box, so changePassivePerception is employed
            changePassivePerception();
        }

        private void chkPersuasionExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkPerformanceExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkReligionExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkSleightOfHandExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkStealthExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        private void chkSurvivalExp_CheckedChanged(object sender, EventArgs e)
        {
            resetAllScores();
        }

        //This is the jack of all trades check box, and it uses its special jackCheckUncheckmethod
        private void chkJackOfAll_CheckedChanged(object sender, EventArgs e)
        {
            jackCheckUncheck(chkJackOfAll.Checked);
        }

        //This is small shortcut method for changeDCSave
        //it uses modAdd to add 8 and the proficiency bonus together.
        private string dcAdd()
        {
            return modAdd("8", lblProfBonus.Text);
        }

        /***************
         * This method is to change the dice check save label.
         * this is affected by the stat chosen, and dcAdd().
         * an if else statement has been used to handle exceptions with 
         * SelectedItem.ToString(). A switch case is then used to determine the 
         * label. This version is used to reset the label when other scores are changed.
         */
        private void changeDCSave()
        {
           
            string chosen;
            if (cmbDCSave.SelectedItem == null)
            {
                chosen = "";
            }
            else
            {
                chosen = cmbDCSave.SelectedItem.ToString().Trim();
            }
            switch (chosen)
            {
                case "Strength":
                    lblDCSave.Text = modAdd(lblStrMod.Text, dcAdd());
                    break;

                case "Dexterity":
                    lblDCSave.Text = modAdd(lblDexMod.Text, dcAdd());
                    break;

                case "Constitution":
                    lblDCSave.Text = modAdd(lblConMod.Text, dcAdd());
                    break;

                case "Intelligence":
                    lblDCSave.Text = modAdd(lblIntMod.Text, dcAdd());
                    break;

                case "Wisdom":
                    lblDCSave.Text = modAdd(lblWisMod.Text, dcAdd());
                    break;

                case "Charisma":
                    lblDCSave.Text = modAdd(lblChaMod.Text, dcAdd());
                    break;

                default:
                    lblDCSave.Text = "0";
                    break;
            }
        }

        /*********
         * This is very similar to changeDCSave(), exept it doesn't check for exceptions,
         * due to it only being used with selected index changed event.
         */
        private void cmbDCSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDCSave.SelectedItem.ToString().Trim())
            {
                case "Strength":
                    lblDCSave.Text = modAdd(lblStrMod.Text, dcAdd());
                    break;
                
                case "Dexterity":
                    lblDCSave.Text = modAdd(lblDexMod.Text, dcAdd());
                    break;

                case "Constitution":
                    lblDCSave.Text = modAdd(lblConMod.Text, dcAdd());
                    break;

                case "Intelligence":
                    lblDCSave.Text = modAdd(lblIntMod.Text, dcAdd());
                    break;

                case "Wisdom":
                    lblDCSave.Text = modAdd(lblWisMod.Text, dcAdd());
                    break;

                case "Charisma":
                    lblDCSave.Text = modAdd(lblChaMod.Text, dcAdd());
                    break;

                default:
                    lblDCSave.Text = "0";
                    break;
            }
        }

        //Changes dex score based on Dex mod. 
        private void changeInitiative()
        {
            int dexMod = Convert.ToInt32(lblDexMod.Text);
            int absDexMod = Math.Abs(dexMod);

            if (dexMod >= 0)
            {
                lblInitiative.Text = "+ " + lblDexMod.Text;
            }
            else
            {
                lblInitiative.Text = "- " + Convert.ToString(absDexMod);
            }
            
        }

        /***************************
        * Clear text boxes when clicked
        ****************************/
        private void txtStr_Enter(object sender, EventArgs e)
        {
            txtStr.Text = "";
        }

        private void txtDex_Enter(object sender, EventArgs e)
        {
            txtDex.Text = "";
        }

        private void txtCon_Enter(object sender, EventArgs e)
        {
            txtCon.Text = "";
        }

        private void txtInt_Enter(object sender, EventArgs e)
        {
            txtInt.Text = "";
        }

        private void txtWis_Enter(object sender, EventArgs e)
        {
            txtWis.Text = "";
        }

        private void txtCha_Enter(object sender, EventArgs e)
        {
            txtCha.Text = "";
        }

        /**************************************
        * Many armors in the game add the dex mod to 
        * a base number to calculate armor class (AC). 
        * Many have a max limit of 2 added to the base armor
        * This function creates that limit
        ***************************************/
        private string armorDexMax()
        {
            int dex = Convert.ToInt32(lblDexMod.Text);

            if (dex >= 2)
            {
                return "2";
            }
            else
            {
                string stringDex = Convert.ToString(dex);
                return stringDex;
            }
        }

        //Calculates armor class based on the string selected
        private void resetAC()
        {
            if (cmbArmor.SelectedItem == null)
            {
                lblAC.Text = "0";
            }
            else
            {
                switch (cmbArmor.SelectedItem.ToString().Trim())
                {
                    case "Breastplate":
                        lblAC.Text = modAdd("14", armorDexMax());
                        break;

                    case "Chain Mail":
                        lblAC.Text = "16";
                        break;

                    case "Chain Shirt":
                        lblAC.Text = modAdd("13", armorDexMax());
                        break;

                    case "Half Plate":
                        lblAC.Text = modAdd("15", armorDexMax());
                        break;

                    case "Hide":
                        lblAC.Text = modAdd("12", armorDexMax());
                        break;

                    case "Leather":
                        lblAC.Text = modAdd("11", lblDexMod.Text);
                        break;

                    case "Padded":
                        lblAC.Text = modAdd("11", lblDexMod.Text);
                        break;

                    case "Plate":
                        lblAC.Text = "18";
                        break;

                    case "Ring Mail":
                        lblAC.Text = "14";
                        break;

                    case "Scale Mail":
                        lblAC.Text = modAdd("14", armorDexMax());
                        break;

                    case "Splint":
                        lblAC.Text = "17";
                        break;

                    case "Studded Leather":
                        lblAC.Text = modAdd("12", lblDexMod.Text);
                        break;

                    case "Unarmored (Barbarian)":
                        lblAC.Text = modAdd("10", modAdd(lblDexMod.Text, lblConMod.Text));
                        break;

                    case "Unarmored (Monk)":
                        lblAC.Text = modAdd("10", modAdd(lblDexMod.Text, lblWisMod.Text));
                        break;

                    default:
                        break;
                }
            }

            //Adding 2 to AC for shield
            if (chkShield.Checked)
            {
                lblAC.Text = modAdd(lblAC.Text, "2");
            }

            //This allows for misc additions to AC
            int num;
            Boolean attempt = int.TryParse(txtMiscAC.Text, out num);
            if (attempt)
            {
                lblAC.Text = modAdd(lblAC.Text, Convert.ToString(num));
            }
        }

        //Recalculating AC when certain boxes are changed

        private void cmbArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetAC();
        }

        private void chkShield_CheckedChanged(object sender, EventArgs e)
        {
            resetAC();
        }

        private void txtMiscAC_TextChanged(object sender, EventArgs e)
        {
            resetAC();
        }

        //Opening new forms for different buttons. 
        private void btnSpellTome_Click(object sender, EventArgs e)
        {
            SpellTome newSpellTome = new SpellTome();
            newSpellTome.Show();
        }

        private void btnDiceGenerator_Click(object sender, EventArgs e)
        {
            frmDiceGenerator newDice = new frmDiceGenerator();
            newDice.Show();
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {
            RaceSelection newRace = new RaceSelection();
            newRace.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string input = "";

        /********************************************************
        * Save button feature. Saves the file as an xml file in the local directory
        *********************************************************/

        private void btnSave_Click(object sender, EventArgs e)
        {
            input = Microsoft.VisualBasic.Interaction.InputBox("Enter your character's name. This will be the name of the save file.", "Save As...", input, 0, 0);
            if (input == "") { }
            else {
                input.Trim();
                try
                {
                    SaveData data = new SaveData();
                    data.Str = txtStr.Text;
                    data.Dex = txtDex.Text;
                    data.Con = txtCon.Text;
                    data.Intel = txtInt.Text;
                    data.Wis = txtWis.Text;
                    data.Cha = txtCha.Text;

                    data.Xp = txtExperience.Text;
                    data.Hpmax = txtMaxHP.Text;
                    data.Hpcurrent = txtCurrentHP.Text;
                    data.Hptemp = txtTemporaryHP.Text;
                    data.Hitdie = txtHitDie.Text;
                    data.Maxhitdie = txtMaxHitDice.Text;
                    data.Curhitdie = txtCurrentHitDice.Text;

                    if (cmbDCSave.SelectedItem != null) data.Caststat = cmbDCSave.SelectedItem.ToString().Trim();
                    if (cmbArmor.SelectedItem != null) data.Armor = cmbArmor.SelectedItem.ToString().Trim();
                    data.Armormisc = txtMiscAC.Text;
                    data.Languages = txtLanguages.Text;
                    data.Gear = txtGear.Text;
                    data.Proficiencies = txtProficiencies.Text;

                    data.Shield = chkShield.Checked;

                    data.AcrobaticsExp = chkAcrobaticsExp.Checked;
                    data.AnimalhandExp = chkAnimalHandExp.Checked;
                    data.ArcanaExp = chkArcanaExp.Checked;
                    data.AthleticsExp = chkAthleticsExp.Checked;
                    data.DeceptionExp = chkDeceptionExp.Checked;
                    data.HistoryExp = chkHistoryExp.Checked;
                    data.InsightExp = chkInsightExp.Checked;
                    data.IntimidationExp = chkIntimidationExp.Checked;
                    data.InvestigationExp = chkInvestigationExp.Checked;
                    data.MedicineExp = chkMedicineExp.Checked;
                    data.NatureExp = chkNatureExp.Checked;
                    data.PerformanceExp = chkPerformanceExp.Checked;
                    data.PersuasionExp = chkPersuasionExp.Checked;
                    data.ReligionExp = chkReligionExp.Checked;
                    data.SleightExp = chkSleightOfHandExp.Checked;
                    data.StealthExp = chkStealthExp.Checked;
                    data.SurvivalExp = chkSurvivalExp.Checked;

                    data.AcrobaticsProf = chkAcrobaticsProf.Checked;
                    data.AnimalhandProf = chkAnimalHandProf.Checked;
                    data.ArcanaProf = chkArcanaProf.Checked;
                    data.AthleticsProf = chkAthleticsProf.Checked;
                    data.DeceptionProf = chkDeceptionProf.Checked;
                    data.HistoryProf = chkHistoryProf.Checked;
                    data.InsightProf = chkInsightProf.Checked;
                    data.IntimidationProf = chkIntimidationProf.Checked;
                    data.InvestigationProf = chkInvestigationProf.Checked;
                    data.MedicineProf = chkMedicineProf.Checked;
                    data.NatureProf = chkNatureProf.Checked;
                    data.PerformanceProf = chkPerformanceProf.Checked;
                    data.PersuasionProf = chkPersuasionProf.Checked;
                    data.ReligionProf = chkReligionProf.Checked;
                    data.SleightProf = chkSleightOfHandProf.Checked;
                    data.StealthProf = chkStealthProf.Checked;
                    data.SurvivalProf = chkSurvivalProf.Checked;

                    data.Jackofall = chkJackOfAll.Checked;
                    data.Inspiration = chkInspiration.Checked;

                    data.Deathfail1 = chkDeathFail1.Checked;
                    data.Deathfail2 = chkDeathFail2.Checked;
                    data.Deathfail3 = chkDeathFail3.Checked;
                    data.Deathpass1 = chkDeathSuccess1.Checked;
                    data.Deathpass2 = chkDeathSuccess2.Checked;
                    data.Deathpass3 = chkDeathSuccess3.Checked;

                    SaveXML.Save(data, input + ".xml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            input = Microsoft.VisualBasic.Interaction.InputBox("Enter your character's name.", "Character Load", input, 0, 0);

            if (File.Exists(input + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(SaveData));
                FileStream read = new FileStream(input + ".xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveData data = (SaveData)xs.Deserialize(read);

                txtStr.Text = data.Str;
                txtDex.Text = data.Dex;
                txtCon.Text = data.Con;
                txtInt.Text = data.Intel;
                txtWis.Text = data.Wis;
                txtCha.Text = data.Cha;

                txtExperience.Text = data.Xp;
                txtMaxHP.Text = data.Hpmax;
                txtCurrentHP.Text = data.Hpcurrent;
                txtTemporaryHP.Text = data.Hptemp;
                txtHitDie.Text = data.Hitdie;
                txtMaxHitDice.Text = data.Maxhitdie;
                txtCurrentHitDice.Text = data.Curhitdie;

                if (data.Caststat != "") cmbDCSave.SelectedItem = data.Caststat;
                if (data.Armor != "") cmbArmor.SelectedItem = data.Armor;
                txtMiscAC.Text = data.Armormisc;
                txtLanguages.Text = data.Languages;
                txtGear.Text = data.Gear;
                txtProficiencies.Text = data.Proficiencies;

                chkShield.Checked = data.Shield;

                chkAcrobaticsExp.Checked = data.AcrobaticsExp;
                chkAnimalHandExp.Checked = data.AnimalhandExp;
                chkArcanaExp.Checked = data.ArcanaExp;
                chkAthleticsExp.Checked = data.AthleticsExp;
                chkDeceptionExp.Checked = data.DeceptionExp;
                chkHistoryExp.Checked = data.HistoryExp;
                chkInsightExp.Checked = data.InsightExp;
                chkIntimidationExp.Checked = data.IntimidationExp;
                chkInvestigationExp.Checked = data.InvestigationExp;
                chkMedicineExp.Checked = data.MedicineExp;
                chkNatureExp.Checked = data.NatureExp;
                chkPerformanceExp.Checked = data.PerformanceExp;
                chkPersuasionExp.Checked = data.PersuasionExp;
                chkReligionExp.Checked = data.ReligionExp;
                chkSleightOfHandExp.Checked = data.SleightExp;
                chkStealthExp.Checked = data.StealthExp;
                chkSurvivalExp.Checked = data.SurvivalExp;

                chkAcrobaticsProf.Checked = data.AcrobaticsProf;
                chkAnimalHandProf.Checked = data.AnimalhandProf;
                chkArcanaProf.Checked = data.ArcanaProf;
                chkAthleticsProf.Checked = data.AthleticsProf;
                chkDeceptionProf.Checked = data.DeceptionProf;
                chkHistoryProf.Checked = data.HistoryProf;
                chkInsightProf.Checked = data.InsightProf;
                chkIntimidationProf.Checked = data.IntimidationProf;
                chkInvestigationProf.Checked = data.InvestigationProf;
                chkMedicineProf.Checked = data.MedicineProf;
                chkNatureProf.Checked = data.NatureProf;
                chkPerformanceProf.Checked = data.PerformanceProf;
                chkPersuasionProf.Checked = data.PersuasionProf;
                chkReligionProf.Checked = data.ReligionProf;
                chkSleightOfHandProf.Checked = data.SleightProf;
                chkStealthProf.Checked = data.StealthProf;
                chkSurvivalProf.Checked = data.SurvivalProf;

                chkJackOfAll.Checked = data.Jackofall;
                chkInspiration.Checked = data.Inspiration;

                chkDeathFail1.Checked = data.Deathfail1;
                chkDeathFail2.Checked = data.Deathfail2;
                chkDeathFail3.Checked = data.Deathfail3;
                chkDeathSuccess1.Checked = data.Deathpass1;
                chkDeathSuccess2.Checked = data.Deathpass2;
                chkDeathSuccess3.Checked = data.Deathpass3;
            }
        }
    }
}

