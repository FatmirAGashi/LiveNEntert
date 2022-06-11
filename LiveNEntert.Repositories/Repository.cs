using LiveNEntert.Domain;
using System.Text;

namespace LiveNEntert.Repositories
{
    public class Repository : IRepository
    {
        public Summary GenerateString(int d1, int d2, Summary counts)
        {
            StringBuilder result = new StringBuilder();

            for (int i = d1; i <= d2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Append("LiveNation ");
                    counts.LiveNation++;
                }
                else if (i % 3 == 0)
                {
                    result.Append("Live ");
                    counts.Live++;
                }
                else if (i % 5 == 0)
                {
                    result.Append("Nation ");
                    counts.Nation++;
                }
                else
                {
                    counts.Integer++;
                    result.Append(i + " ");
                }

            }
            counts.Result = result.ToString();
            return counts;
        }
    }
}
