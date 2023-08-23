using System;

namespace Simple_CRUD.Data
{
    internal class MemberIdEventArgs : EventArgs
    {
        public long MemberId { get; init; }

        public MemberIdEventArgs(long memberId)
        {
            MemberId = memberId;
        }
    }
}
