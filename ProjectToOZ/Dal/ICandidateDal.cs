using ProjectToOZ.Models; 
namespace ProjectToOZ.Dal
{
    public interface ICandidateDal
    {
        Task<string> GetCandidates();
        Task<List<Candidate>> GetCandidatesList();
    }
}