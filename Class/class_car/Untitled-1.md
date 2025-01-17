# Супориши амалӣ / Практическое задание / Practical Task

## 🇹🇯 Тоҷикӣ

### Тавсиф
Шумо бояд класси Product созед, ки молро дар мағоза идора мекунад.

### Майдонҳои класс
- `private string Name` - номи мол
- `private decimal Price` - нархи мол бо рубл
- `private int StockQuantity` - миқдори мол дар анбор
- `private string Category` - категорияи мол
- `private bool IsDiscounted` - оё мол тахфиф дорад

### Методҳо

#### 1. Методи "Гузоштани тахфиф"
```csharp
public string SetDiscount(int discountPercent)
```
Тасаввур кунед, ки шумо дар мағоза кор мекунед ва бояд ба мол тахфиф гузоред:
- Агар 20 ворид кунед - нархи мол 20% кам мешавад
- Агар 1000 рубл буд, баъд аз тахфиф 800 рубл мешавад
- Метод паёми "Нархи нав: 800 рубл"-ро бармегардонад
- Агар тахфиф нодуруст бошад - "Тахфифи нодуруст" менависад

#### 2. Методи "Моли нав омад"
```csharp
public string AddNewItems(int count)
```
Моли нав ба анбор омад:
- Чанд дона мол овардаанд менависед (масалан 5 дона)
- Ин рақам ба миқдори мавҷуда илова мешавад
- Паёми "Ҳоло дар анбор: 15 дона" бармегардонад
- Агар рақами манфӣ ворид кунед - "Хатои таъминот" менависад

#### 3. Методи "Фурӯши мол"
```csharp
public string SellItem(int count)
```
Харидор мехоҳад мол харад:
- Чанд дона харидан мехоҳад менависед
- Агар мол кифоя бошад - миқдор дар анбор кам мешавад
- Паёми "Фурӯхта шуд! Нарх: 2000 рубл" бармегардонад
- Агар мол кифоя набошад - "Дар анбор мол кифоя нест" менависад

#### 4. Методи "Санҷиши мавҷудият"
```csharp
public string CheckAvailability()
```
Санҷед чанд мол мондааст:
- Агар зиёда аз 20 дона - "Моли бисёр"
- Агар аз 5 то 20 - "Моли кифоя"
- Агар камтар аз 5 - "Таъминоти фаврӣ лозим!"
- Ба паём миқдори аниқро илова мекунад, масалан: "Моли кифоя (15 дона)"

#### 5. Методи "Маълумот барои нархнома"
```csharp
public string GetPriceTag()
```
Бояд нархнома чоп кард:
- Ҳамаи маълумотро дар бораи мол ҷамъ мекунад
- Агар тахфиф бошад, нархи кӯҳна ва навро менависад
- Мисол бе тахфиф: "Телефони Samsung, Нарх: 20000 рубл"
- Мисол бо тахфиф: "Телефони Samsung, Нархи кӯҳна: 20000 рубл, Нархи нав: 16000 рубл (Тахфиф!)"

## 🇷🇺 Русский

### Описание
Вам нужно создать класс Product, который будет управлять товаром в магазине.

### Поля класса
- `private string Name` - название товара
- `private decimal Price` - цена товара в рублях
- `private int StockQuantity` - количество товара на складе
- `private string Category` - категория товара
- `private bool IsDiscounted` - есть ли скидка на товар

### Методы

#### 1. Метод "Установить скидку"
```csharp
public string SetDiscount(int discountPercent)
```
Представь что ты работаешь в магазине и тебе нужно установить скидку на товар:
- Если введёшь 20 - цена товара уменьшится на 20%
- Если было 1000 рублей, после скидки будет 800 рублей
- Метод возвращает сообщение "Новая цена: 800 рублей"
- Если скидка неправильная - пишет "Неверная скидка"

#### 2. Метод "Привезли новый товар"
```csharp
public string AddNewItems(int count)
```
Привезли новую поставку товара:
- Вводишь сколько товара привезли (например 5 штук)
- Это число добавляется к тому что уже есть на складе
- Возвращает сообщение "Теперь на складе: 15 штук"
- Если пытаешься добавить отрицательное число - пишет "Ошибка поставки"

#### 3. Метод "Продажа товара"
```csharp
public string SellItem(int count)
```
Покупатель хочет купить товар:
- Указываешь сколько штук хочет купить
- Если товара достаточно - уменьшает количество на складе
- Возвращает сообщение "Продано! Стоимость: 2000 рублей"
- Если товара не хватает - пишет "Недостаточно товара на складе"

#### 4. Метод "Проверка наличия"
```csharp
public string CheckAvailability()
```
Проверяем сколько товара осталось:
- Если больше 20 штук - пишет "Много товара"
- Если от 5 до 20 - пишет "Достаточно товара"
- Если меньше 5 - пишет "Срочно нужна поставка!"
- Добавляет к сообщению точное количество, например: "Достаточно товара (15 шт.)"

#### 5. Метод "Информация для ценника"
```csharp
public string GetPriceTag()
```
Нужно распечатать ценник:
- Собирает всю информацию о товаре
- Если есть скидка, пишет старую и новую цену
- Пример без скидки: "Телефон Samsung, Цена: 20000 руб."
- Пример со скидкой: "Телефон Samsung, Старая цена: 20000 руб., Новая цена: 16000 руб. (Скидка!)"

## 🇬🇧 English

### Description
You need to create a Product class that will manage a product in a store.

### Class Fields
- `private string Name` - product name
- `private decimal Price` - product price in rubles
- `private int StockQuantity` - quantity in stock
- `private string Category` - product category
- `private bool IsDiscounted` - whether the product is discounted

### Methods

#### 1. Method "Set Discount"
```csharp
public string SetDiscount(int discountPercent)
```
Imagine you work in a store and need to set a discount on a product:
- If you enter 20 - the product price will decrease by 20%
- If it was 1000 rubles, after discount it will be 800 rubles
- Method returns message "New price: 800 rubles"
- If discount is invalid - writes "Invalid discount"

#### 2. Method "New Items Arrived"
```csharp
public string AddNewItems(int count)
```
New product delivery arrived:
- Enter how many items arrived (for example 5 pieces)
- This number is added to what's already in stock
- Returns message "Now in stock: 15 pieces"
- If you try to add a negative number - writes "Delivery error"

#### 3. Method "Sell Item"
```csharp
public string SellItem(int count)
```
Customer wants to buy a product:
- Specify how many pieces they want to buy
- If enough product - decreases quantity in stock
- Returns message "Sold! Cost: 2000 rubles"
- If not enough product - writes "Not enough items in stock"

#### 4. Method "Check Availability"
```csharp
public string CheckAvailability()
```
Check how much product is left:
- If more than 20 pieces - writes "Lots of items"
- If 5 to 20 - writes "Sufficient items"
- If less than 5 - writes "Urgent delivery needed!"
- Adds exact quantity to message, for example: "Sufficient items (15 pcs)"

#### 5. Method "Price Tag Information"
```csharp
public string GetPriceTag()
```
Need to print a price tag:
- Collects all information about the product
- If there's a discount, writes old and new price
- Example without discount: "Samsung Phone, Price: 20000 rub"
- Example with discount: "Samsung Phone, Old price: 20000 rub, New price: 16000 rub (Discount!)"

### Пример использования / Мисоли истифода / Usage Example

```csharp
Product phone = new Product();
phone.Name = "Samsung Galaxy";
phone.Price = 20000;
phone.StockQuantity = 10;
phone.Category = "Electronics";

Console.WriteLine(phone.CheckAvailability());    // "Sufficient items (10 pcs)"
Console.WriteLine(phone.SetDiscount(20));        // "New price: 16000 rubles"
Console.WriteLine(phone.SellItem(3));            // "Sold! Cost: 48000 rubles"
Console.WriteLine(phone.AddNewItems(5));         // "Now in stock: 12 pieces"
Console.WriteLine(phone.GetPriceTag());          // "Samsung Galaxy, Old price: 20000 rub, New price: 16000 rub (Discount!)"
```

## Вазифаи иловагӣ / Дополнительное задание / Additional Tasks
- Ҳисоби маблағи умумии фурӯш дар як рӯз / Подсчёт общей суммы продаж за день / Add total sales amount for the day
- Имконияти бекор кардани тахфиф / Возможность отменить скидку / Add ability to cancel discount
- Илова кардани промокод / Добавление промокода / Add promo code functionality
