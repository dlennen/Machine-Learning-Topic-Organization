using MLTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTO.Contracts
{
    public interface IAlgorithm
    {
        bool CreateAlgorithm(AlgorithmCreate model);
        IEnumerable<AlgorithmListItem> GetAlgorithms();
        AlgorithmDetail GetAlgorithmById(int AlgorithmId);
        bool UpdateAlgorithm(AlgorithmEdit model);
        bool DeleteAlgorithm(int AlgorithmId);
    }
}
