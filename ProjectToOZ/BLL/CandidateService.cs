using ProjectToOZ.Dal;
using ProjectToOZ.Models;

namespace ProjectToOZ.BLL
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateDal _candidateDal;
        public CandidateService(ICandidateDal candidateDal)
        {
            _candidateDal = candidateDal;
        }

        //async Task<List<Present>> GetPresentsAsync()
        public async Task<string> GetCandidatesAsync()
        {
            return await _candidateDal.GetCandidates();
        }

        public async Task<List<Candidate>> GetCandidatesAsyncList()
        {
            return await _candidateDal.GetCandidatesList();
        }

    }
}



//public async Task<List<Present>> GetPresentsAsync()
//{
//    return await _presentDal.GetPresentsAsync();
//}