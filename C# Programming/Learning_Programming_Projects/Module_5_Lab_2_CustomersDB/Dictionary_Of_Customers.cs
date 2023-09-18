namespace Module_5_Lab_2_CustomersDB
{
    class Dictionary_Of_Customers
    {
        string _customer { get; set; }
        string _email { get; set; }
        string _name { get; set; }
        string _password { get; set; }

        public void Adding_Customers()
        {
            Dictionary<string, string> myCustomers = new Dictionary<string, string>();
            foreach(var c in _customer)
            {
                myCustomers.Add(_customer, c++);
            }

        }




    }
}
