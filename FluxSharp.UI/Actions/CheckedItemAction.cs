﻿namespace FluxSharp.Actions
{
    public class CheckedItemAction
    {
        public CheckedItemAction(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
