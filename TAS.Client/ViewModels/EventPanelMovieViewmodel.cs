﻿using TAS.Common.Interfaces;

namespace TAS.Client.ViewModels
{
    public class EventPanelMovieViewmodel: EventPanelRundownElementViewmodelBase
    {
        public EventPanelMovieViewmodel(IEvent ev, EventPanelViewmodelBase parent) : base(ev, parent)
        {
        }

        protected override void OnDispose()
        {
            if (IsSelected)
            {
                var p = Prior;
                if (p != null)
                    p.IsSelected = true;
            }
            base.OnDispose();
        }
    }
   
}
