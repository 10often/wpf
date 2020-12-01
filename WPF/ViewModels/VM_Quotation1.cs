using LibDefinitions;
using System.Collections.ObjectModel;
using WPF.Core;

namespace WPF.ViewModels
{
    public class VM_Quotation1 : VM_Basic
    {
        public ObservableCollection<Quotation> ListQuotation { get; set; } = new ObservableCollection<Quotation>();

        public VM_Quotation1()
        {
            LoadFromModel();
        }

        public void LoadFromModel()
        {
            var items = Ap.MC.Quotation;
            ListQuotation.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                ListQuotation.Add(items[i]);
            }
        }
    }
}
