USE master;  -- Chuyển sang DB hệ thống để tránh "đang dùng CARO"
DROP DATABASE IF EXISTS CARO;  -- Xóa nếu tồn tại
CREATE DATABASE CARO;          -- Tạo lại database
USE CARO;                      -- Sử dụng CARO

-- 1. Bảng User (Thông tin Người chơi & Xếp hạng)
CREATE TABLE [User] (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(50) UNIQUE NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    elo_score INT NOT NULL DEFAULT 1000,
    current_rank INT NULL,
    join_date DATETIME NOT NULL DEFAULT GETDATE(),
    is_online BIT NOT NULL DEFAULT 0
);
GO

---

-- 2. Bảng Game (Lịch sử Trận đấu & Kết quả)
CREATE TABLE Game (
    game_id INT PRIMARY KEY IDENTITY(1,1),
    player_x_id INT NOT NULL,
    player_o_id INT NOT NULL,
    winner_id INT NULL,
    start_time DATETIME NOT NULL,
    end_time DATETIME NULL,
    
    game_mode VARCHAR(20) NOT NULL 
        CHECK (game_mode IN ('PVP_RANKED', 'PVP_FRIEND', 'PVE_BOT')),
    
    result VARCHAR(10) NOT NULL DEFAULT 'ONGOING' 
        CHECK (result IN ('X_WIN', 'O_WIN', 'DRAW', 'ONGOING')),
    
    elo_change_x INT NULL,
    elo_change_o INT NULL,
    
    FOREIGN KEY (player_x_id) REFERENCES [User](user_id),
    FOREIGN KEY (player_o_id) REFERENCES [User](user_id),
    FOREIGN KEY (winner_id) REFERENCES [User](user_id)
);
GO

---

-- 3. Bảng Move (Chi tiết Nước đi)
CREATE TABLE Move (
    move_id INT PRIMARY KEY IDENTITY(1,1),
    game_id INT NOT NULL,
    player_id INT NOT NULL,
    move_number INT NOT NULL,
    coord_x INT NOT NULL,
    coord_y INT NOT NULL,
    move_time DATETIME NOT NULL,
    
    FOREIGN KEY (game_id) REFERENCES Game(game_id),
    FOREIGN KEY (player_id) REFERENCES [User](user_id)
);
GO

---

-- 4. Bảng Friendship (Hệ thống Kết bạn)
CREATE TABLE Friendship (
    friendship_id INT PRIMARY KEY IDENTITY(1,1),
    user1_id INT NOT NULL,
    user2_id INT NOT NULL,
    
    status VARCHAR(10) NOT NULL DEFAULT 'PENDING'
        CHECK (status IN ('PENDING', 'ACCEPTED', 'BLOCKED')),
    
    action_user_id INT NULL,
    created_at DATETIME NOT NULL DEFAULT GETDATE(),
    updated_at DATETIME NOT NULL DEFAULT GETDATE(),
    
    FOREIGN KEY (user1_id) REFERENCES [User](user_id),
    FOREIGN KEY (user2_id) REFERENCES [User](user_id),
    FOREIGN KEY (action_user_id) REFERENCES [User](user_id),
    
    -- Đảm bảo không có hai bản ghi trùng lặp (vd: 1-2 và 2-1)
    CONSTRAINT UQ_Friendship UNIQUE (user1_id, user2_id)
);
GO

---

-- 5. Bảng PrivateMessage (Nhắn tin 1-1)
CREATE TABLE PrivateMessage (
    message_id INT PRIMARY KEY IDENTITY(1,1),
    sender_id INT NOT NULL,
    receiver_id INT NOT NULL,
    
    -- Dùng NVARCHAR(MAX) thay cho TEXT
    content NVARCHAR(MAX) NOT NULL,
    
    -- Dùng BIT thay cho BOOLEAN
    is_read BIT NOT NULL DEFAULT 0, 
    
    sent_at DATETIME NOT NULL DEFAULT GETDATE(),
    
    FOREIGN KEY (sender_id) REFERENCES [User](user_id),
    FOREIGN KEY (receiver_id) REFERENCES [User](user_id)
);
GO