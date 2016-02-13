using System;

namespace WhoToFollowApp
{
    public class RefreshEventArgs : EventArgs
    {
        public new static readonly RefreshEventArgs Empty = new RefreshEventArgs();
    }

    public class CloseEventArgs : EventArgs
    {
        public CloseEventArgs(int index)
        {
            this.Index = index;
        }

        public int Index { get; private set; }
    }

    public class LinkEventArgs : EventArgs
    {
        public LinkEventArgs(Uri url)
        {
            this.Url = url;
        }
        public Uri Url { get; private set; }
    }
}
