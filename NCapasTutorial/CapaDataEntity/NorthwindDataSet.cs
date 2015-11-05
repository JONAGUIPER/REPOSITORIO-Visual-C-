namespace CapaDataEntity
{
    partial class NorthwindDataSet
    {
        partial class OrdersDataTable
        {
            public override void EndInit()
            {
                base.EndInit();
                // Configure the ColumnChanging event
                // to call the SampleColumnChangingEvent method.
                ColumnChanging += SampleColumnChangingEvent;
                OrdersRowChanging += SampleRowChangingEvent;
            }

            private void SampleRowChangingEvent(object sender, OrdersRowChangeEvent e)
            {
                // Perfom the validation logic.
                if (e.Row.RequiredDate <= e.Row.OrderDate)
                {
                    // Set the row to an error when validation fails.
                    e.Row.RowError = "La fecha Requerida no puede ser igual oanterior a OrderDate";
                }
                else
                {
                    // Clear the RowError if validation passes.
                    e.Row.RowError = "";
                }
            }

            public void SampleColumnChangingEvent(object sender, System.Data.DataColumnChangeEventArgs e)
            {
                if (e.Column.ColumnName == OrderDateColumn.ColumnName)
                {
                    if ((System.DateTime)e.ProposedValue > System.DateTime.Today)
                    {
                        e.Row.SetColumnError("OrderDate", " OrderDate cannot be in the future");
                    }
                    else
                    {
                        e.Row.SetColumnError("OrderDate", "");
                    }
                }
                if (e.Column.ColumnName == columnShipVia.ColumnName)
                {
                    if ((short)e.ProposedValue <= 0)
                    {
                        e.Row.SetColumnError("ShipVia", "Esta via de envio no es correcta");
                    }
                    else
                    {
                        e.Row.SetColumnError("ShipVia", "");
                    }
                }
            }
        }
    }
}
