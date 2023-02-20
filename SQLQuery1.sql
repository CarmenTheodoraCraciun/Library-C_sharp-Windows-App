select id_bill from bills where send_to='false' and is_done='true';

select isbn ISBN,title Title,author Author,gender Gender from books where isbn in (select isbn from bills_detalies where id_bill=1) order by isbn;

update bills set send_to='true' where id_bill=1;

select * from 