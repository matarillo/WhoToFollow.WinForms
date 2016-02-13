using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WhoToFollowApp
{
    public class PersonToFollow
    {
        public string Name { get; set; }

        public Uri Url { get; set; }

        public Uri Image { get; set; }
    }

    public class PeopleToFollow : BindingList<PersonToFollow>
    {
        public PeopleToFollow()
        {
        }

        public PeopleToFollow(IList<PersonToFollow> collection)
            : base(collection)
        {
        }
    }
}
