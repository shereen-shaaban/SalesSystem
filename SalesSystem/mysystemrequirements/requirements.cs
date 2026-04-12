using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SalesSystem.mysystemrequirements
{
    internal class requirements
    {
		/*	entities:
				product
				Order
				OrderProduct
				Customer
				Payment
				Employee
				Office
				ProductLine
		*/

		/*		relations:
				product=====>can be in zero rows or many  rows
				orderproduct===>every row must has product id(follow some product)

				order=====>can be in zero rows or many  rows   in orderproduct
				orderproduct===>every row must has order id(follow some product)

				customer====>can has zero or more orders
				order===>if any row is in the table then it must follow some customer

				customer=====>can has zero or more payments
				payment===>if it has row in the table then must follow some cusomer


				Employee==>can do many orders to many customers or not (if he new) so we need to make relation between employee and customer to know which employee can do order for which customer
					so we will make many to many relation between employee and customer with table name employeecustomer
						employee====>can do order for zero or more customers
						customer====>can make order with zero or more employees
				customer====>can have many orders with many employees or not (if he new) so we need to make relation between employee and customer to know which employee can do order for which customer
					so we will make many to many relation between employee and customer with table name employeecustomer
						employee====>can do order for zero or more customers
						customer====>can make order with zero or more employees


				Employee==>can be managed by only one manager or it hasn't manager
				Manager====>must manage one or more employee


				Employee=====>must be in only one office
				Office====>can has zero(new branch) or more than employees

				product====>any product must has product line
				product line ======>can has zero or more products
		*/


	}
}
