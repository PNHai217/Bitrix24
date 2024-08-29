Công nghệ sử dụng:
- C# ASP.NET CORE, Bootstrap, JavaScript, jQuery
- Các thư viện công cụ bổ sung: Postman, Ajax, SweetAlert
- Các API và công cụ tích hợp: Bitrix API

Logic chương trình:
- Chương trình hiển thị danh sách user được lấy từ API
- Nút Refresh: Khi click vào nút Refresh, chương trình sẽ xuất hiện một SweetAlert hỏi Bạn có muốn làm mới danh sách không, Click vào Yes chương trình sẽ làm mới danh sách(sử dụng ajax để làm mới bảng thông tin user mà không cần tải lại toàn bộ trang khiến cho trái nghiệm người dùng tốt hơn), Click vào Cancel để hủy.
- Selected user: Khi click vào user nào thì dòng thông tin của user đó sẽ được Highlight, sau khi chọn được user muốn hiển thị thông tin click tiếp vào nút View Employee để hiển thị một popup có thông tin của user vừa được chọn. Trường hợp chưa chọn user nào mà chọn nút View Employee, chương trình sẽ hiển thị thông báo "Bạn chưa chọn user nào".
