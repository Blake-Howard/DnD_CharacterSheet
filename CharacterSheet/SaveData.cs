using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class SaveData
    {
        private string str;
        private string dex;
        private string con;
        private string intel;
        private string wis;
        private string cha;

        private string xp;
        private string hpmax;
        private string hpcurrent;
        private string hptemp;
        private string hitdie;
        private string maxhitdie;
        private string curhitdie;

        private string caststat;
        private string armor;
        private string armormisc;
        private string languages;
        private string gear;
        private string proficiencies;

        private bool shield;

        private bool acrobaticsExp;
        private bool animalhandExp;
        private bool arcanaExp;
        private bool athleticsExp;
        private bool deceptionExp;
        private bool historyExp;
        private bool insightExp;
        private bool intimidationExp;
        private bool investigationExp;
        private bool medicineExp;
        private bool natureExp;
        private bool perceptionExp;
        private bool performanceExp;
        private bool persuasionExp;
        private bool religionExp;
        private bool sleightExp;
        private bool stealthExp;
        private bool survivalExp;

        private bool acrobaticsProf;
        private bool animalhandProf;
        private bool arcanaProf;
        private bool athleticsProf;
        private bool deceptionProf;
        private bool historyProf;
        private bool insightProf;
        private bool intimidationProf;
        private bool investigationProf;
        private bool medicineProf;
        private bool natureProf;
        private bool perceptionProf;
        private bool performanceProf;
        private bool persuasionProf;
        private bool religionProf;
        private bool sleightProf;
        private bool stealthProf;
        private bool survivalProf;

        private bool jackofall;
        private bool inspiration;

        private bool deathpass1;
        private bool deathpass2;
        private bool deathpass3;
        private bool deathfail1;
        private bool deathfail2;
        private bool deathfail3;

        /****************************************/
        public string Str {
            get { return str; }
            set { str = value; }
        }
        public string Dex{
            get { return dex; }
            set { dex = value; }
        }
        public string Con{
            get { return con; }
            set { con = value; }
        }
        public string Intel{
            get { return intel; }
            set { intel = value; }
        }
        public string Wis{
            get { return wis; }
            set { wis = value; }
        }
        public string Cha{
            get { return cha; }
            set { cha = value; }
        }

        public string Xp{
            get { return xp; }
            set { xp = value; }
        }
        public string Hpmax{
            get { return hpmax; }
            set { hpmax = value; }
        }
        public string Hpcurrent{
            get { return hpcurrent; }
            set { hpcurrent = value; }
        }
        public string Hptemp{
            get { return hptemp; }
            set { hptemp = value; }
        }
        public string Hitdie{
            get { return hitdie; }
            set { hitdie = value; }
        }
        public string Maxhitdie{
            get { return maxhitdie; }
            set { maxhitdie = value; }
        }
        public string Curhitdie{
            get { return curhitdie; }
            set { curhitdie = value; }
        }

        public string Caststat{
            get { return caststat; }
            set { caststat = value; }
        }
        public string Armor{
            get { return armor; }
            set { armor = value; }
        }
        public string Armormisc{
            get { return armormisc; }
            set { armormisc = value; }
        }
        public string Languages{
            get { return languages; }
            set { languages = value; }
        }
        public string Gear{
            get { return gear; }
            set { gear = value; }
        }
        public string Proficiencies{
            get { return proficiencies; }
            set { proficiencies = value; }
        }

        public bool Shield{
            get { return shield; }
            set { shield = value; }
        }

        /****************************************************/
        public bool AcrobaticsExp{
            get { return acrobaticsExp; }
            set { acrobaticsExp = value; }
        }
        public bool AnimalhandExp{
            get { return animalhandExp; }
            set { animalhandExp = value; }
        }
        public bool ArcanaExp{
            get { return arcanaExp; }
            set { arcanaExp = value; }
        }
        public bool AthleticsExp{
            get { return athleticsExp; }
            set { athleticsExp = value; }
        }
        public bool DeceptionExp{
            get { return deceptionExp; }
            set { deceptionExp = value; }
        }
        public bool HistoryExp{
            get { return historyExp; }
            set { historyExp = value; }
        }
        public bool InsightExp{
            get { return insightExp; }
            set { insightExp = value; }
        }
        public bool IntimidationExp{
            get { return intimidationExp; }
            set { intimidationExp = value; }
        }
        public bool InvestigationExp{
            get { return investigationExp; }
            set { investigationExp = value; }
        }
        public bool MedicineExp{
            get { return medicineExp; }
            set { medicineExp = value; }
        }
        public bool NatureExp{
            get { return natureExp; }
            set { natureExp = value; }
        }
        public bool PerceptionExp
        {
            get { return perceptionExp; }
            set { perceptionExp = value; }
        }
        public bool PerformanceExp{
            get { return performanceExp; }
            set { performanceExp = value; }
        }
        public bool PersuasionExp{
            get { return persuasionExp; }
            set { persuasionExp = value; }
        }
        public bool ReligionExp{
            get { return religionExp; }
            set { religionExp = value; }
        }
        public bool SleightExp{
            get { return sleightExp; }
            set { sleightExp = value; }
        }
        public bool StealthExp{
            get { return stealthExp; }
            set { stealthExp = value; }
        }
        public bool SurvivalExp{
            get { return survivalExp; }
            set { survivalExp = value; }
        }

        public bool AcrobaticsProf
        {
            get { return acrobaticsProf; }
            set { acrobaticsProf = value; }
        }
        public bool AnimalhandProf
        {
            get { return animalhandProf; }
            set { animalhandProf = value; }
        }
        public bool ArcanaProf
        {
            get { return arcanaProf; }
            set { arcanaProf = value; }
        }
        public bool AthleticsProf
        {
            get { return athleticsProf; }
            set { athleticsProf = value; }
        }
        public bool DeceptionProf
        {
            get { return deceptionProf; }
            set { deceptionProf = value; }
        }
        public bool HistoryProf
        {
            get { return historyProf; }
            set { historyProf = value; }
        }
        public bool InsightProf
        {
            get { return insightProf; }
            set { insightProf = value; }
        }
        public bool IntimidationProf
        {
            get { return intimidationProf; }
            set { intimidationProf = value; }
        }
        public bool InvestigationProf
        {
            get { return investigationProf; }
            set { investigationProf = value; }
        }
        public bool MedicineProf
        {
            get { return medicineProf; }
            set { medicineProf = value; }
        }
        public bool NatureProf
        {
            get { return natureProf; }
            set { natureProf = value; }
        }
        public bool PerceptionProf
        {
            get { return perceptionProf; }
            set { perceptionProf = value; }
        }
        public bool PerformanceProf
        {
            get { return performanceProf; }
            set { performanceProf = value; }
        }
        public bool PersuasionProf
        {
            get { return persuasionProf; }
            set { persuasionProf = value; }
        }
        public bool ReligionProf
        {
            get { return religionProf; }
            set { religionProf = value; }
        }
        public bool SleightProf
        {
            get { return sleightProf; }
            set { sleightProf = value; }
        }
        public bool StealthProf
        {
            get { return stealthProf; }
            set { stealthProf = value; }
        }
        public bool SurvivalProf
        {
            get { return survivalProf; }
            set { survivalProf = value; }
        }

        public bool Jackofall{
            get { return jackofall; }
            set { jackofall = value; }
        }
        public bool Inspiration{
            get { return inspiration; }
            set { inspiration = value; }
        }

        public bool Deathpass1{
            get { return deathpass1; }
            set { deathpass1 = value; }
        }
        public bool Deathpass2
        {
            get { return deathpass2; }
            set { deathpass2 = value; }
        }
        public bool Deathpass3
        {
            get { return deathpass3; }
            set { deathpass3 = value; }
        }
        public bool Deathfail1
        {
            get { return deathfail1; }
            set { deathfail1 = value; }
        }
        public bool Deathfail2
        {
            get { return deathfail2; }
            set { deathfail2 = value; }
        }
        public bool Deathfail3
        {
            get { return deathfail3; }
            set { deathfail3 = value; }
        }
    }
}

