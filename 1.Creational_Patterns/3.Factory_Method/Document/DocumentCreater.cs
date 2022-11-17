using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    public abstract class DocumentCreater
    {
        private List<Page> _pages = new List<Page>();
        public List<Page> Pages { get { return _pages; } }
        public DocumentCreater()
        {
            this.CreatePages();
        }

        public abstract void CreatePages();
        
    }

    public class Resume : DocumentCreater
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    public class Report : DocumentCreater
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
