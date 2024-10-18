# การทดลอง
## การ debug .NET console application โดยใช้ Visual Studio Code

ใบงานนี้จะทำการ debug .NET console application โดยใช้ Visual Studio Code

## การเตรียมการเบื้องต้น
- โปรแกรม HelloWorld ที่สร้างในใบงาน [Week15_labsheet1.md](./Week15_labsheet1.md)

## การ debug application

1. แก้ไขโปรแกรมในเมธอด `static void Main(string[] args)` ของ ไฟล์ `Program.cs`

![alt text](./Pictures/image-15.png)

2. เพิ่มเมธอด `static int Add(int var1, int var2)`

![alt text](./Pictures/image-16.png)

3. ตรวจสอบให้แน่ใจว่าไฟล์ `Program.cs` มีเนื้อหาดังต่อไปนี้

![alt text](./Pictures/image-17.png)

4. คลิกที่แถบด้านซ้ายตัวเลขบรรทัด เพื่อตั้ง break point ที่บรรทัด  `int a = 1;`

![alt text](./Pictures/image-18.png)

5. กด F5 เพื่อ debug โปรแกรม

![alt text](./Pictures/image-19.png)

6. เมื่อแถบสีเหลืองปรากฏบนบรรทัดที่ 7 ให้สังเกตุค่าตัวแปรต่างๆ ในหน้าต่างย่อย VARIABLES 

 ![alt text](./Pictures/image-20.png)

7. กดปุ่ม Step Over (F10) 

![alt text](./Pictures/image-21.png)

8. สังเกตุหน้าต่าง Program.cs และหน้าต่างย่อย VARIABLES แต่ละขั้นของการ Step over ไปทีละบรรทัดจนจบโปรแกรม

**บันทึกผลการทดลอง**
ผลที่ได้จากการทำงานในแต่ละบรรทัด  ถูกต้องตามที่เขียนเขียนโปรแกรมไว้หรือไม่

![สกรีนช็อต 2024-10-18 100139](https://github.com/user-attachments/assets/056300d2-34d9-4c06-9612-95ef39ea3d30)

![สกรีนช็อต 2024-10-18 100148](https://github.com/user-attachments/assets/7096ef0e-8956-4d37-b1c6-3d8584250d2c)

![สกรีนช็อต 2024-10-18 100158](https://github.com/user-attachments/assets/87ba38ca-3b2a-4185-b90a-cf779a8d559e)

![สกรีนช็อต 2024-10-18 100219](https://github.com/user-attachments/assets/446ba1c6-89cb-4510-98e8-1de88d988a70)

![สกรีนช็อต 2024-10-18 100230](https://github.com/user-attachments/assets/3470f325-91d2-4466-bbb9-09ebf0c6f440)

**หมายเหตุ**
ในการ debug เราสามารถใช้ command pallette ในการสั่งการได้ 

สามารถเรียกโดยใช้ Ctrl+Shift+P  แล้วพิมพ์ debug ลงในช่องค้นหาคำสั่ง ดังตัวอย่าง

![alt text](/Pictures/image-22.png)

9. ตรวจสอบให้แน่ใจว่าตั้ง break point ไว้ที่บรรทัดที่ 7 แล้ว รันคำสั่ง Debug:Start Without Debugging     

![alt text](./Pictures/image-23.png)

**บันทึกผลการทดลอง**
- การรันคำสั่ง Start Without Debugging ให้ผลเหมือนหรือต่างจากการ debug
  ![สกรีนช็อต 2024-10-18 100740](https://github.com/user-attachments/assets/fe212d91-5d70-4e51-8fb6-226ab5900466)

- การตั้ง break point มีผลอย่างไรกับการรันในโหมด Start Without Debugging หรือไม่
- ตอบ การตั้ง break point ไม่มีผลเมื่อรันโปรแกรมในโหมด Start Without Debugging เนื่องจากโหมดนี้จะทำการรันโปรแกรมตามปกติ โดยไม่เข้าสู่โหมดดีบัก โปรแกรมจะทำงานจนเสร็จสมบูรณ์หรือเกิดข้อผิดพลาดตามปกติโดยไม่หยุดที่จุด break point ที่ตั้งไว้

