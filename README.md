# AzureNotificationHub MAUI .Net (Android)
Send Firebase (FCM V1) push notification to physical device using Azure Notification Hub

# Backend deployment 
I have used dev tunnel url to access backend services. 
For more infomation about **dev tunnel** please visit below url

Vedio (https://www.youtube.com/watch?v=72hs_IlE-GY)

information: https://learn.microsoft.com/en-us/aspnet/core/test/dev-tunnels?view=aspnetcore-8.0

# Please Follow below steps to configure Firebase FCM v1 into Azure notification hub
1) Create Notification Hub on https://portal.azure.com/
![Creat Notification Hub](https://github.com/user-attachments/assets/5a4bc557-5087-4f53-aa67-cc59eddf5b13)

2) Notification hub Deployement inprogress
   ![Azure Notification Hub deployment](https://github.com/user-attachments/assets/528eb618-3505-45af-9304-04dc72aeea05)

3) Deployment successfuly
   ![Deployment completed](https://github.com/user-attachments/assets/4b510ff7-95e7-4701-86af-fbf568aa8741)
4) Backend connection string
![Azure Access policies](https://github.com/user-attachments/assets/e66c4465-2d48-49d8-84b3-87a497faa76d)

5) Generate private key into firebase console(Firebase Admin SDK)
![Generate New Private key on Fire base notification](https://github.com/user-attachments/assets/42b5ab8a-6b8b-400b-9df2-b2f5882eb5dd)

6) Configure FCM v1 in Azure Notification Hub
<img width="632" alt="firebaseadmin" src="https://github.com/user-attachments/assets/ff9661bc-f5bd-4076-a5bc-8a2c803cab52">

![Configure Google FCM](https://github.com/user-attachments/assets/116e1227-7cc5-4b99-9981-8108f956d447)

7) Azure Notificaiton Hub Dashboard
![Notification Dashboard](https://github.com/user-attachments/assets/f6f73419-ba7f-4e94-9df9-b2ea64b3a6b6)

8) Send Test Notification
![Send Test notification](https://github.com/user-attachments/assets/2b9f6c38-48df-43ef-8b22-8368ee1842cd)

9) Notificaiton Output

![Received Notification](https://github.com/user-attachments/assets/2958fa22-0d42-4ebf-a12b-de790469ba26)

   
# Note:Please download and configure google-services.json file into the Android platform.
