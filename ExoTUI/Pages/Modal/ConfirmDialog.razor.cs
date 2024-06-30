using Microsoft.AspNetCore.Components;

namespace ExoTUI.Pages.Modal
{
    public partial class ConfirmDialog
    {
        [Parameter]
        public bool Show { get; set; }

        [Parameter]
        public EventCallback OnCancel { get; set; }

        [Parameter]
        public EventCallback OnOk { get; set; }
    }
}