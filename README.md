
 
זהו פרויקט ASP.NET Core Web (model-view-controller) המספק מערכת לניהול מאגר קורונה עבור קופת חולים גדולה. המערכת מאפשרת למשתמשים להציג וליצור נתונים הקשורים לחברי קופת החולים באופן כללי וכן נתונים על הקורונה, כגון מידע על מטופל, תוצאות בדיקות ורישומי חיסונים.


כדי להפעיל את הפרויקט באופן מקומי, יהיה עליך להתקין את התוכנה Visual Studio מגרסאת 2019 ומעלה  , כמו כן גם את SQL Server Management Studio(ssms. בצע את השלבים הבאים כדי להתחיל:

טענו את המאגר למחשב המקומי שלכם.
פתחו את קובץ הפתרון ב-Visual Studio  .
שחזרו את חבילות NuGet על ידי לחיצה ימנית על הפתרון בסייר הפתרונות ובחירה ב"שחזר חבילות NuGet".
צרו מסד נתונים חדש ב-SQL Server Management Studio, והפעילו את סקריפט ה-SQL שנמצא בתיקייה "Database" כדי ליצור את הטבלאות והנתונים הדרושים.
עדכנו את מחרוזת החיבור בקובץ "appsettings.json" כך שתצביע על מופע ה-SQL Server המקומי שלך.
בנו והפעילו את הפרויקט.
שימוש 
כאשר נריץ את הפרויקט יפתח לנו דף ובו בלמעלה הדף יהיו שתי כפתורים האחד הצגת כל המטופלים ושני הוספת מטופל.
נפרט על כל אחד:

1.כאשר נלחץ על הצגת המטופלים יופיע לנו רשימה ובה המטופלים ופרטיהם שם תעודת זהות וכו, עבור כל מטופ יהיה לנו כפתור של פרטי חיסון שהוא יציג לנו גם את החיסונים שהוא עשה ובמידה ולא עשה 4 יאפשר גם להוסיף.
2.כאשר נלחץ על הוספה יפתח לנו כפתור ובו יהיה עלינו להשלים את הפרטים עבור מטופל זה רק כאשר כל השדות יהיו מלאות ותקינות המטופל יתווסף למאגר.
(השתמשתי בשביל לבנות את הפרויקט בסרטון המופיע ביוטיוב
https://www.youtube.com/watch?v=_uSw8sh7xKs