﻿using Leave.Infrastructure.Commands.Base;

namespace Leave.Infrastructure.Commands.Furloughs
{
    public class CreateFurlough : ICommand
    {
        public int UserId { get; set; }
    }
}
