<b>01.</b> Разработать класс Book <b>(ISBN, автор, название, издательство, год издания, количество страниц, цена)</b>, переопределив для него необходимые методы класса Object. Для объектов класса реализовать <b>отношения эквивалентности и порядка (используя соответствующие интерфейсы)</b>. Для выполнения основных операций со списком книг, который <b>можно</b> загрузить и, <b>если возникнет необходимость</b>, сохранить в некоторое хранилище BookListStorage разработать класс BookListService (как сервис для работы с <b>коллекцией</b> книг) с функциональностью AddBook (добавить книгу, если такой книги нет, в противном случае выбросить исключение); RemoveBook (удалить книгу, если она есть, в противном случае выбросить исключение); FindBookByTag (найти книгу по заданному критерию); SortBooksByTag (отсортировать список книг по заданному критерию), при реализации делегаты не использовать!
Работу классов продемонстрировать на примере консольного приложения. 
В качестве хранилища использовать
- двоичный файл, для работы с которым использовать только классы <b>BinaryReader, BinaryWriter. Хранилище в дальнейшем может измениться/добавиться.</b>

<b>02.</b> Разработать систему типов для описания работы с банковским счетом. Состояние счета определяется его номером, данными о владельце счета (имя, фамилия), суммой на счете и некоторыми бонусными баллами, которые увеличиваются/уменьшаются каждый раз при пополнении счета/списании со счета на величины различные для пополнения и списания и рассчитываемые в зависимости от некоторых значений величин «стоимости» баланса и «стоимости» пополнения. Величины «стоимости» баланса и «стоимости» пополнения являются целочисленными значениями и зависят от градации счета, который может быть, например,  Base, Gold, Platinum.
Для работы со счетом реализовать следующие возможности:
<ul>
 <li>выполнить пополнение на счет;</li>
 <li>выполнить списание со счета;</li>
 <li>создать новый счет;</li>
 <li>закрыть счет. </li>
</ul>
Информация о счетах храниться в бинарном файле.
Работу классов продемонстрировать на примере консольного приложения. 
При проектировании типов учитывать следующие возможности расширения/изменения функциональности:
<ul>
 <li>добавление новых видов счетов;</li>
 <li>изменение/добавление источников хранения информации о счетах;</li>
 <li>изменение логики расчета бонусных баллов.</li>
</ul>



