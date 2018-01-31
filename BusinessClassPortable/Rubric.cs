using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClassPortable
{
    /// <summary>
    /// Business class to build a rubric
    /// </summary>
    public class Rubric
    {
        public int RubricId { get; set; }
        public string Title { get; set; }

        #region Builders

        public Rubric() { }
        public Rubric(int rubricId, string title)
        {
            RubricId = rubricId;
            Title = title;
        }

        #endregion

        /// <summary>
        /// Rubric comparison by id and title
        /// </summary>
        /// <param name="obj">other rubric</param>
        /// <returns>true if equals</returns>
        public override bool Equals(object obj)
        {
            Rubric r = obj as Rubric;
            if (r == null) return false;
            return RubricId == r.RubricId && Title == r.Title;
        }
    }
}
