using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Group : IParticipant
    {
        public string Name { get; set; }
        public List<IParticipant> Members { get; set; }

        public Group()
        {
            Members = new List<IParticipant>();
        }

        public double Gold
        {
            get => Members.Select(x => x.Gold).Sum();
            set
            {
                double eachSplit = value / Members.Count;
                double leftOver = value % Members.Count;
                foreach (IParticipant member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats() => Members.ForEach(x => x.Stats());
    }
}
