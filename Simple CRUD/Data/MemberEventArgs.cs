using System;

namespace Simple_CRUD.Data
{
    internal class MemberEventArgs : EventArgs
    {
        public Member Member { get; init; }

        public MemberEventArgs(Member member)
        {
            Member = member;
        }
    }
}
