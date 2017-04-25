using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilderApplicationDemo.CV
{
   public class Skill
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private SkillLevel skillLevel;

        public SkillLevel SkillLevel
        {
            get { return skillLevel; }
            set { skillLevel = value; }
        }

    }
}
