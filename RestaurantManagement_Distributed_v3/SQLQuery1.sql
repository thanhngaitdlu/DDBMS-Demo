select * from BillDetail
select * from Bill
select * from Food

--Tim mon an ban chay nhat trong thang, nam

select f.Name, sum(bd.Quantity)
FROM Food f, BillDetail bd, Bill b
where bd.FoodID = f.ID and bd.BillID = b.ID and month(b.CheckoutDate) = 2
group by f.Name
having sum(bd.Quantity) >= (select top 1 sum(Quantity) sl from BillDetail group by FoodID order by sl desc)

-- Tim nhan vien lap nhieu phieu nhat
select Employee, count(Employee)
from Bill
group by Employee
order by count(Employee)

--having count(Employee) >= 
--(select top 1 count(b.Employee)
--from Bill b
--group by b.Employee
--order by count(b.Employee))

-- Tim nhan vien khong lap hoa don nao
select e.FirstName + ' ' + e.LastName as FullName
from Employee e
where not exists(
select b.Employee
from Bill b
where b.Employee = e.ID)
--group by b.Employee

-- Tim mon an khong duoc chon trong thang, nam
select Name
from Food f
where not exists( select distinct bd.FoodID 
					from BillDetail bd inner join Bill b on bd.BillID = b.ID
					where  month(b.CheckoutDate) = 3 and year(b.CheckoutDate) = 2021 and bd.FoodID = f.ID)

select Name
from Food f
where ID not in (select distinct bd.FoodID 
					from BillDetail bd, Bill b
					where bd.BillID = b.ID and month(b.CheckoutDate) = 3 and year(b.CheckoutDate) = 2021 )		



