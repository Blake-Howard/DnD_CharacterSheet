using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Spell
    {
        private string mySpellName;
        private string myPage;
        private string myLevel;
        private string mySchool;
        private string myCastTime;
        private string myRitual;
        private string myVComponent;
        private string mySComponent;
        private string myMComponent;
        private string myConcentration;
        private string myDescription;

        public Spell( string strSpellName, string strPage, string strLevel, string strSchool, string strCastTime,
            string strRitual, string strVComponent, string strSComponent, string strMComponent, string strConcentration,
                string strDescription)
        {
            this.mySpellName = strSpellName;
            this.myPage = strPage;
            this.myLevel = strLevel;
            this.mySchool = strSchool;
            this.myCastTime = strCastTime;
            this.myRitual = strRitual;
            this.myVComponent = strVComponent;
            this.mySComponent = strSComponent;
            this.myMComponent = strMComponent;
            this.myConcentration = strConcentration;
            this.myDescription = strDescription;
        }

        public string SpellName
        {
            get { return mySpellName; }
            set { mySpellName = value;}
        }

        public string Page
        {
            get { return myPage; }
            set { myPage = value; }
        }

        public string Level
        {
            get { return myLevel; }
            set { myLevel = value; }
        }

        public string School
        {
            get { return mySchool; }
            set { mySchool = value; }
        }

        public string CastTime
        {
            get { return myCastTime; }
            set { myCastTime = value; }
        }
        
        public string Ritual
        {
            get { return myRitual; }
            set { myRitual = value; }
        }

        
        public string VComponent
        {
            get { return myVComponent; }
            set { myVComponent = value; }
        }

        public string SComponent
        {
            get { return mySComponent; }
            set { mySComponent = value; }
        }

        public string MComponent
        {
            get { return myMComponent; }
            set { myMComponent = value; }
        }

        public string Concentration
        {
            get { return myConcentration; }
            set { myConcentration = value; }
        }

        public string Description
        {
            get { return myDescription; }
            set { myDescription = value; }
        }
    }
}
