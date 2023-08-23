using System;

namespace Simple_CRUD.Data
{
    internal class MessageBroker
    {
        public event EventHandler DatabaseChangedEvent;
        public event EventHandler EditMemberEvent;
        public event EventHandler DeleteMemberEvent;
        public event EventHandler AddMemberEvent;
        public event EventHandler UpdateMemberEvent;
        public event EventHandler ClearMemberEvent;

        public void NotifyDatabaseChange()
        {
            DatabaseChangedEvent?.Invoke(this, EventArgs.Empty);
        }

        public void EditMember(long memberId)
        {
            EditMemberEvent?.Invoke(this, new MemberIdEventArgs(memberId));
        }

        public void DeleteMember(long memberId)
        {
            DeleteMemberEvent?.Invoke(this, new MemberIdEventArgs(memberId));
        }

        public void AddMember(Member member)
        {
            AddMemberEvent?.Invoke(this, new MemberEventArgs(member));
        }

        public void UpdateMember(Member member)
        {
            UpdateMemberEvent?.Invoke(this, new MemberEventArgs(member));
        }

        public void ClearMember()
        {
            ClearMemberEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
