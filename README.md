##          MÔ TẢ CÁC CHỨC NĂNG CHỨC
<details>
  <summary>Mục đích xây dựng ứng dụng</summary>

- Xây dựng một nền tảng tất cả trong một. Người quản trị, giảng viên, học viên có thể sử dụng công cụ để học tập trực tuyến, tra cứu kết quả học tập, đăng ký học phần, quản trị đào tạo, ...
- Nâng cao tính chính xác, bảo mật trong quản lý thông tin học viên.
- Thay thế các ứng dụng quản lý đã lỗi thời.
- Giao diện, luồng xử lý phù hợp hơn với nhu cầu của người sử dụng.
</details>

<details>

- Nhu cầu của quản trị viên
  - Quản lý đào tạo bao gồm: lớp kỹ năng, khóa - hệ đào tạo, môn học.
  - Quản lý danh sách học viên, giảng viên, quản trị viên.
  - Tạo đợt đăng ký học.
  - Thêm các trường thông tin mới cho học viên, giảng viên.

- Nhu cầu của giáo viên
  - Chỉnh sửa, cập nhật thông tin cá nhân.
  - Xem lịch, thời khóa biểu giảng dạy.
  - Thêm điểm cho học viên.

- Nhu cầu của học viên
  - Chỉnh sửa, cập nhật thông tin cá nhân.
  - Xem lớp môn học đã và đang học.
  - Xem thời khóa biểu, lịch thi.
  - Xem kết quả học tập, điểm rèn luyện.
  - Đăng ký môn học.

  </details>

## Yêu cầu chức năng chi tiết

<details>
  <summary>Quản lý lớp học</summary>

- Hiển thị thông tin lớp môn học: kỹ năng, mã kỹ năng, sĩ số, giảng viên, thời khóa biểu, …
- Tìm kiếm các lớp kỹ năng theo mã lớp, giảng viên dạy.
- Thêm, sửa, xóa các lớp môn học.
- Hiển thị các lớp kỹ năng theo quyền, theo học kỳ.
- Đi đến trang thông tin chi tiết của lớp kỹ năng.

</details>

<details>
  <summary>Quản lý chi tiết lớp kỹ năng</summary>.
- Danh sách học viên trong lớp học
  - Xem tổng quan, thống kê điểm số học viên trong lớp.
  - Xem thông tin học viên trong lớp.
  - Thêm học viên vào lớp.
  - Xóa học viên ra khỏi lớp.
  - Tra cứu học viên trong lớp.
  - Thêm, sửa, xóa điểm thành phần cho lớp học.
  - Thêm, sửa, xóa điểm cho học viên trong lớp.

</details>

<details>
  <summary>Quản lý khoa - hệ đào tạo</summary>

- Hiển thị thông tin, số lượng học viên ứng với từng hệ.
- Hiển thị thông tin, số lượng học viên ứng với từng hệ đào tạo.
- Thêm, sửa, xóa khoa.
- Thêm, sửa, xóa hệ đào tạo.
- Tìm kiếm khoa theo tên khoa hoặc theo tên hệ đào tạo mà khoa có.
- Thêm hệ đào tạo tương ứng với khoa.

</details>

<details>
  <summary>Quản lý lớp kỹ năng</summary>

- Hiển thị danh sách và thông tin các lớp kỹ năng : tên kỹ ănng, mã kỹ năng, số buổi, mô tả, …
- Tìm kiếm môn học theo mã kỹ năng, tên kỹ năng.
- Thêm, sửa, xóa điểm kỹ năng.
- Thêm môn học từ excel.

</details>

<details>
  <summary>Quản lý đăng ký học phần</summary>
  
- Quản trị viên
  - Thêm học kỳ và đóng mở học kỳ.
  - Thêm lớp môn học thủ công hoặc thêm từ file excel.
  - Xem chi tiết, sửa, xóa.
- học viên
  - Đăng ký, hủy đăng ký lớp .
  - Trực quan hóa các lớp môn học bằng thời khóa biểu.
  - Đánh dấu những lớp bị trùng giờ học.
  - Tìm kiếm lớp môn học chưa đăng ký theo tên, mã lớp học.

</details>

<details>
  <summary>Quản lý thời khóa biểu</summary>
  
- Hiển thị danh sách các lớp môn học dưới dạng bảng thời khóa biểu.
- Hiển thị các lớp môn học theo quyền (giáo viên, học viên), theo học kỳ.

</details>

<details>
  <summary>Quản lý Thông tin cá nhân</summary>

- Hiển thị thông tin cá nhân của người dùng
- Chỉnh sửa thông tin cá nhân theo quyền

</details>

<details>
  <summary>Quản lý cài đặt Thông tin cá nhân (Quản trị viên)</summary>

- HIển thị các trường thông tin cá nhân theo role
- Thêm, xóa , sửa, ẩn, xem các cài đặt của trường thông tin theo role

</details>

<details>
  <summary>Quản lý người dùng (Quản trị viên)</summary>

- Thiết lập, cung cấp tài khoản và mật khẩu cho người dùng (học viên, giáo viên, Quản trị viên).
- Thêm người dùng thủ công và từ file.
- Chỉnh sửa, cập nhật thông tin cho người dùng.
- Tìm kiếm thông tin người dùng.

</details>

<details>
  <summary>Quản lý điểm (học viên)</summary>

- Xem bảng điểm học viên.
- Xuất bảng điểm học viên (future work)

</details>
