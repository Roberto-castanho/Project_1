public virtual SalesOrder_CreateOutput Create(SalesOrder_CreateInput _data)
{
	SalesOrder_CreateOutput res = new SalesOrder_CreateOutput();
	using (AdventureWorksEntities ctx = new AdventureWorksEntities())
	{
		EntityState state = EntityState.Added;
		SalesOrder obj = new SalesOrder();
		var entry = ctx.Entry(obj);
		entry.State = state;
		entry.CurrentValues.SetValues(_data);
		UpdateCustomer(ctx, obj, _data.Customer);
		UpdatePayment(ctx, obj, _data.Payment);
		UpdateSales(ctx, obj, _data.Sales);
		obj.OrderDate = DateTime.Now;
		obj.ModifiedDate = DateTime.Now;
		ErrorList.Current.AbortIfHasErrors(HttpStatusCode.BadRequest);
		ctx.SaveChanges();
		ServiceUtil.CopyProperties(obj, res);
	}

	return res;
}