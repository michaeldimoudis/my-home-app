﻿namespace MyHomeApp.Models
{
    public enum TokenResult
    {
        Empty,
        Valid,
        Invalid,
        NeedsRefresh,
        RefreshedSuccessfully,
        Error
    }
}