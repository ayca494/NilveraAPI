using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Enums
{
    public enum AnswerCode
    {
        unknown = 0,
        waitingForApproval = 1,
        approved = 2,
        rejected = 3,
        documentAnsweredAutomatically = 4
    }
}
