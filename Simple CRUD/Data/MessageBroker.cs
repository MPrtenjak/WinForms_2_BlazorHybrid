﻿using System;

namespace Simple_CRUD.Data
{
    internal class MessageBroker
    {
        public event EventHandler DatabaseChangedEvent;
        public event EventHandler EditMemberEvent;
        public event EventHandler DeleteMemberEvent;

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
    }
}
