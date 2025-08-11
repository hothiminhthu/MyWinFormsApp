                ,____________________________________,
               /  ,__________________________________, \
              /  / //////////////////////////////   /  \
             /  / //    //    //    //    //    //  /   \
            /  / //    //    //    //    //    //  /   \
           /  / //////////////////////////////   /  \
          /  /__________________________________/   \
         /___________________________________________\
         |___________________________________________|
        /      / |                               | \     \
       /      /  |_______________________________|  \     \
      /      /  /_________________________________\  \     \
     (      (  (___________________________________)  )     )
      \      \   \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \/  /     /
       \      \   \ \ \ \ \ \ \ \ \ \ \ \ \ \ \/   /     /
        \      \   \ \ \ \ \ \ \ \ \ \ \ \ \/    /     /
         \      \   \ \ \ \ \ \ \ \ \ \ \/     /     /
          \      \   \ \ \ \ \ \ \ \/       /     /
           \      \   \ \ \ \ \/         /     /
            \      \   \ \ \/          /     /
             \      \   \/          /     /
              \      \           /     /
               \      \        /     /
                \      \_____/     /
                 \_______________/

Ngày xửa ngày xưa 🌌, có một lập trình viên (vâng, chính là tui 😎) 
đang lạc lối trong thế giới debug và deploy thủ công…

🔄 Mỗi lần sửa code → build tay 🛠  
📂 Copy file thủ công → lỡ quên backup → “Tạm biệt bản cũ” 😱  
💥 Deploy xong mới biết… app crash toàn tập.

💡 Rồi một ngày, Jenkins xuất hiện như một **hiệp sĩ CI/CD**:

"Để ta lo cho, từ build → test → deploy, nhanh gọn như Ronaldo SIUUUU!" ⚡

Kể từ đó, mỗi lần tui gõ `git push`:

1️⃣ **📬 Nhận tin qua Webhook GitHub**  
2️⃣ **📥 Kéo code mới nhất về**  
3️⃣ **🛠 Build WinForms bằng MSBuild**  
4️⃣ **📦 Backup bản cũ** (phòng drama)  
5️⃣ **🚀 Deploy bản mới trong vài giây**  

🎯 Kết quả: Tui chỉ việc… gõ lệnh, uống cà phê ☕, còn Jenkins lo phần còn lại.  
