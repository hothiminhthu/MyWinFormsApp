      _____         _       
     |  __ \       | |      
     | |__) |__  __| |_   _ 
     |  ___/ _ \/ _` | | | |
     | |  |  __/ (_| | |_| |
     |_|   \___|\__,_|\__, |
                       __/ |
                      |___/ 

## 📜 Câu chuyện
Ngày xửa ngày xưa, có một lập trình viên (chính là **tui** 😎) mệt mỏi vì:
- Mỗi lần sửa code lại phải build thủ công 🛠
- Copy file tay, nhỡ quên backup → “Tạm biệt bản cũ” 😱
- Deploy xong mới biết… app lỗi 💥

Rồi một ngày đẹp trời 🌤, **Jenkins** xuất hiện như một vị cứu tinh:
> “Để ta tự động hóa tất cả cho cậu, từ build, test, đến deploy! 💪”

Và thế là cuộc hành trình **CI/CD** cho WinForms bắt đầu...  
Mỗi khi tui gõ `git push` → Jenkins sẽ:
1. 📬 Nhận tin qua **Webhook GitHub**.
2. 📥 Kéo code mới nhất về.
3. 🛠 Build dự án WinForms với **MSBuild**.
4. 📦 Backup bản cũ (phòng trường hợp drama).
5. 🚀 Deploy bản mới vào server chỉ trong **vài giây**.

---

## 📂 Cấu trúc dự án
