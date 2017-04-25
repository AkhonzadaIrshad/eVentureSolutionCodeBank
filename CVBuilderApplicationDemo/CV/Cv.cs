using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilderApplicationDemo.CV
{
    class Cv
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private PersonalInfo personalInfo;

        public PersonalInfo PersonalInfo
        {
            get { return personalInfo; }
            set { personalInfo = value; }
        }

        private List<ExperienceInfo> experienceInfos;

        public List<ExperienceInfo> ExperienceInfos
        {
            get { return experienceInfos; }
            set { experienceInfos = value; }
        }

        private List<EducationalInfo> educationalInfos;

        public List<EducationalInfo> EducationalInfos
        {
            get { return educationalInfos; }
            set { educationalInfos = value; }
        }

        private List<Skill> skills;

        public List<Skill> Skills
        {
            get { return skills; }
            set { skills = value; }
        }
        private List<Project> projects;

        public List<Project> Projects
        {
            get { return projects; }
            set { projects = value; }
        }

    }
}
