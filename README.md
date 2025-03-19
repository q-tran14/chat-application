# chat-application
## Hướng dẫn clone và push project lên remote repo
### Cấu trúc thư mục:
--- + FinalProject
  
------ + chat-application

--------- + .git

--------- + ...

--------- + [file].sln

### Các bước:
#### Clone repo về và set up cho git trên local
1. Tạo 1 thư mục rỗng "FinalProject"
2. cd FinalProject
3. git clone https://github.com/q-tran14/chat-application.git
4. cd chat-application
5. git checkout -b [MSSV] : mọi thay đổi 

#### Push commit mới lên từ branch [MSSV]
1. git status : Hiện trạng thái các file đã được thêm và chỉnh sửa - Ở trạng thái track hoặc untracked
2. git add .
3. git commit -m "[Về những gì đã làm. Ví dụ: Thêm class, chỉnh sửa code chức năng]"
4. git push -u origin [MSSV]
5. Lên github tạo pull request để merge branch [MSSV] vô master

#### Từ lần thứ 2 push commit lên (Thực hiện các lệnh sau trước khi push lên remote repo)
- Lưu ý: sau khi thực hiện xong các thay đổi trên project, lúc này đang ở branch [MSSV]
1. git status
2. git add .
3. git commit -m "[Về những gì đã làm. Ví dụ: Thêm class, chỉnh sửa code chức năng]"
4. git fetch origin master
5. git merge origin/master
6. Có conflict thì nhắn tin tui
6. git push origin [MSSV]
7. Lên github tạo pull request để merge branch [MSSV] vô master
