USE CorazonDeCafe;
GO

INSERT INTO categories
    (name, status)
VALUES
    ('Grano', 1),
    ('Molido', 1),
    ('Soluble', 1);
GO

INSERT INTO types
    (name, status)
VALUES
    ('Premium', 1),
    ('Origen', 1),
    ('Sostenible', 1);
GO

INSERT INTO roles
    (name, status)
VALUES
    ('Admin', 1),
    ('Gerente', 1),
    ('Supervisor', 1),
    ('Vendedor', 1);

GO

INSERT INTO payment_methods
    (description, status)
VALUES
    ('Efectivo', 1),
    ('Credito', 1),
    ('Debito', 1),
    ('Mercado Pago', 1);
GO

INSERT INTO billing_types
    (description, status)
VALUES
    ('Factura A', 1),
    ('Factura B', 1);
GO

INSERT INTO addresses
    (street, number, city, province, postal_code)
VALUES
    ('Av 13 de abril', 1017, 'Corrientes', 'Corrientes', '3400'),
    ('Av 25 de abril', 2015, 'Corrientes', 'Corrientes', '3400'),
    ('Calle de los Sueños', 123, 'La Imaginación', 'Los Deseos', '1100'),
    ('Avenida de las Estrellas', 456, 'Los Sueños', 'Los Encantos', '2200'),
    ('Calle de la Luna Brillante', 789, 'La Fantasía', 'Las Maravillas', '3040'),
    ('Avenida de las Sonrisas', 1011, 'La Alegría', 'La Felicidad', '4000'),
    ('Calle del Arco Iris', 1213, 'LAsombro', 'Los Secretos', '5500'),
    ('Avenida de los Misterios', 1415, 'Las Sorpresas', 'Los Enigmas', '6000'),
    ('Calle de la Aventura', 1617, 'La Emoción', 'La Exploración', '7800'),
    ('Avenida de la Imaginación', 1819, 'La Creatividad', 'La Innovación', '8000'),
    ('Calle de los Descubrimientos', 2021, 'La Maravilla', 'Los Hallazgos', '8002'),
    ('Avenida de los Sueños Hechos Realidad', 2223, 'La Realización', 'Los Logros', '1001');

GO

INSERT INTO users
    (name, surname, email, dni, address_id, status, phone)
VALUES
    ('pc-admin', 'pc-admin', 'pc-admin@admin.com', '1111111', NULL, 1, NULL),
    ('Erika', 'Fernandez', 'erika@fernandez.com', '66666666', NULL, 1, NULL),
    ('Sebastian', 'Gonzalez', 'sebastian@guevara.com', '77777777', NULL, 1, NULL),
    ('Johan', 'Guevara', 'johanguevara@gmail.com', '12345678', NULL, 1, NULL),
    ('Juan', 'Pérez', 'juanperez@example.com', '12335678', 1, 1, '1234567890'),
    ('María', 'González', 'mariagonzalez@example.com', '23456789', 2, 1, '1234567891'),
    ('Carlos', 'Rodríguez', 'carlosrodriguez@example.com', '34567890', 3, 1, '1234567892'),
    ('Laura', 'Martínez', 'lauramartinez@example.com', '45678901', 4, 1, '1234567893'),
    ('Pedro', 'Sánchez', 'pedrosanchez@example.com', '56789012', 5, 1, '1234567894'),
    ('Ana', 'López', 'analopez@example.com', '67890123', 6, 1, '1234567895'),
    ('José', 'Ramírez', 'joseramirez@example.com', '78901234', 7, 1, '1234567896'),
    ('Isabel', 'Torres', 'isabeltorres@example.com', '89012345', 8, 1, '1234567897'),
    ('Luis', 'Fernández', 'luisfernandez@example.com', '90123456', 9, 1, '1234567898'),
    ('Carmen', 'García', 'carmengarcia@example.com', '12340123', 10, 1, '1234567899'),

    -- NUEVOS EMPLEADOS
    ('Marco', 'Torres', 'marcotorrez@gmail.com', '22445566', NULL, 1, '2123456781'),
    ('Laura', 'Gonzalez', 'lauragonzalez@gmail.com', '33557788', NULL, 1, '2123456782');

GO

INSERT INTO employees
    (username, pass, user_id, role_id)
VALUES
    ('pc-admin', 'admin', 1, 1),
    ('eri-admin', 'admin', 2, 2),
    ('seb-admin', 'admin', 3, 3),
    ('empleado1', '12345678', 4, 4),
    ('empleado2', '22445566', 15, 4),
    ('empleado3', '33557788', 16, 4);

GO

INSERT INTO customers
    (user_id)
VALUES
    (5),
    (6),
    (7),
    (8),
    (9),
    (10),
    (11),
    (12),
    (13),
    (14);

GO

INSERT INTO products
    (name, price, createdById, imagen, stock, category_id, type_id, status, active)
VALUES
    ('Café Soluble Clásico', 2875.2, 2, '1684177493_9563141ec4aa484c70ac.png', 12, 3, 2, 1, 1),
    ('Café Soluble Descafeinado', 3355.4, 2, '1684178073_06f5b37192de6b4c40ca.png', 10, 3, 2, 1, 1),
    ('Café Soluble Sabor Vainilla', 3835.7, 2, '1684178094_414e871c5b48d23a12f7.png', 12, 3, 3, 1, 1),
    ('Café Soluble Sabor Caramelo', 4315.2, 2, '1684178114_9afe9a7a7bb7139722b9.png', 11, 3, 1, 1, 1),
    ('Café Soluble Sabor Chocolate', 4795.2, 2, '1684178140_1e9dbf6620bb2ed3aa37.png', 12, 3, 2, 1, 1),
    ('Café Soluble Sabor Avellana', 5275.2, 2, '1684178157_094882e71102f5e65ac8.png', 18, 3, 3, 1, 1),
    ('Café Soluble Instantáneo', 2875.2, 2, '1684178177_4263bbf475652c43667b.png', 7, 3, 1, 1, 1),
    ('Café Soluble Orgánico', 3355.9, 2, '1684178199_ae76e8cb4d2fc90dc52b.png', 13, 3, 2, 1, 1),
    ('Café Soluble Intenso', 3355.4, 2, '1684178214_59149ee1b58a9ba8f676.png', 6, 3, 3, 1, 1),
    ('Café Soluble Premium', 4315.2, 2, '1684178233_053f0c1becb0375d6e55.png', 9, 3, 1, 1, 1),
    ('Café en Grano 100% Arábica', 5755.2, 2, '1684178256_0750a38008064108249b.png', 11, 1, 1, 1, 1),
    ('Café en Grano Tueste Medio', 6235.2, 2, '1684178277_4837e505045dc3efda01.png', 2, 1, 2, 1, 1),
    ('Café en Grano Tueste Oscuro', 6715.3, 2, '1684178308_f0a452f55ed9dfa189df.png', 16, 1, 3, 1, 1),
    ('Café en Grano Origen Brasil', 7195.2, 2, '1684178325_cdb1314d33aa15006db4.png', 19, 1, 1, 1, 1),
    ('Café en Grano Origen Colombia', 7675.8, 2, '1684178347_ea8a3ee4c72e3ddcf17b.png', 2, 1, 1, 1, 1),
    ('Café en Grano Mezcla Especial', 4795.2, 2, '1684178364_a518127e5e314b228a08.png', 4, 1, 3, 1, 1),
    ('Café en Grano Molido Fino', 5755.7, 2, '1684178399_c2ed19b4a23e9fdfd2a1.png', 17, 1, 1, 1, 1),
    ('Café en Grano Molido Grueso', 6235.1, 2, '1684178425_fe45b48c33aed7d96595.png', 20, 1, 2, 1, 1),
    ('Café en Grano Sabor Canela', 5755.7, 2, '1684178444_114968f3609af260af33.png', 3, 1, 2, 1, 1),
    ('Café en Grano Sabor Nuez', 7195.2, 2, '1684178462_1755472eb7469bed172e.png', 1, 1, 1, 1, 1),
    ('Café Molido Clásico', 4315.6, 2, '1684179396_b6f6c50f1979158550bd.png', 10, 2, 2, 1, 1),
    ('Café Molido Descafeinado', 4795.9, 2, '1684179421_1c96ec326f563b220136.png', 15, 2, 1, 1, 1),
    ('Café Molido Tueste Medio', 5275.2, 2, '1684179564_617d5a3192ffc1bba454.png', 8, 2, 1, 1, 1),
    ('Café Molido Tueste Oscuro', 5755.2, 2, '1684179583_5f170a3a3896a250e003.png', 5, 2, 2, 1, 1),
    ('Café Molido Origen Guatemala', 6235.2, 2, '1684179605_6e8e802cc5d5d9bb8943.png', 12, 2, 1, 1, 1),
    ('Café Molido Origen Etiopía', 6715.2, 2, '1684179623_b620965270c8f3fa4508.png', 18, 2, 1, 1, 1),
    ('Café Molido Mezcla Especial', 7195.2, 2, '1684179644_298a1d68d2ac9f72bc91.png', 7, 2, 2, 1, 1),
    ('Café Molido Sabor Caramelo', 8155.2, 2, '1684179679_c210a1f97ef1f606996d.png', 13, 2, 1, 1, 1),
    ('Café Molido Aromático', 7675.2, 2, '1684179707_fdf3074cb1db41986156.png', 6, 2, 3, 1, 1),
    ('Café Molido Sabor Vainilla', 8635.2, 2, '1684179723_4226cb98cbed95ad822c.png', 9, 2, 1, 1, 1),
    ('Prueba del cambio de imagen', 2500.25, 2, 'c5eb10bb-349a-40c3-b608-fc009fbf5dbc.png', 5, 1, 3, 1, 1),
    ('Prueba final de imagen', 3500.0, 2, '8cdd6530-7a9b-4e46-bf61-73a440e65b04.png', 14, 2, 3, 1, 1),
    ('Otro producto mas', 3500.75, 2, 'a6c00cb3-aaed-4a09-81e9-16e854983f76.png', 10, 2, 2, 1, 1),
    ('Producto a eliminar', 2500.0, 2, '974c667e-9f0a-4e34-a419-3dccc8246fa6.png', 12, 2, 3, 0, 1);

GO

INSERT INTO orders
    (customer_id, employee_id, customer_cuit, status, total_price, payment_method_id, billing_type_id, createdAt, updatedAt)
VALUES
    (1, 4, NULL, 1, 13905.0, 1, 2, '2023-08-03T14:08:44.837', NULL),
    (4, 6, '21-46022028-4', 1, 16306.8, 2, 1, '2023-08-10T14:08:44.837', NULL),
    (4, 5, '21-46022028-4', 1, 25422.1, 2, 1, '2023-08-15T14:08:44.837', NULL),
    (6, 4, '17-26052028-2', 1, 45606.8, 1, 1, '2023-08-20T14:08:44.837', NULL),
    (7, 4, NULL, 1, 12610.6, 3, 2, '2023-08-22T14:08:44.837', NULL),
    (7, 5, NULL, 1, 21582.5, 3, 2, '2023-08-24T14:08:44.837', NULL),
    (8, 6, '20-16052028-1', 1, 32277.9, 3, 1, '2023-08-25T14:08:44.837', NULL),
    (3, 5, '18-16052228-9', 1, 21683.347, 1, 2, '2023-08-26T15:52:57.963', NULL),
    (10, 5, NULL, 0, 16543.38, 3, 2, '2023-09-13T17:43:35.523', NULL),
    (4, 3, NULL, 1, 16543.38, 1, 2, '2023-09-16T17:47:41.407', NULL),
    (7, 3, NULL, 1, 18256.98, 1, 2, '2023-09-17T21:52:01.14', NULL),
    (8, 5, NULL, 1, 16273.786, 1, 2, '2023-09-18T22:09:36.013', NULL),
    (6, 5, NULL, 1, 21685.846, 1, 2, '2023-09-20T17:39:04.91', NULL),
    (5, 3, NULL, 1, 34815.949, 1, 2, '2023-09-22T17:43:37.03', NULL),
    (2, 3, NULL, 1, 23169.776, 1, 2, '2023-09-23T17:57:47.72', NULL),
    (8, 4, '20-40042026-9', 1, 15977.059, 4, 1, '2023-09-25T18:11:44.59', NULL),
    (4, 3, NULL, 1, 54224.135, 1, 2, '2023-10-15T18:25:30.793', NULL),
    (4, 3, NULL, 1, 29673.84, 1, 2, '2023-10-15T18:27:01.91', NULL),
    (4, 4, NULL, 1, 13811.795, 1, 2, '2023-10-16T18:28:56.75', NULL),
    (10, 4, NULL, 1, 22825.747, 1, 2, '2023-10-16T18:31:02.703', NULL),
    (8, 4, NULL, 1, 21112.385, 1, 2, '2023-10-16T18:34:21.5', NULL),
    (8, 5, NULL, 1, 35385.84, 1, 2, '2023-10-17T18:35:42.397', NULL),
    (1, 6, NULL, 1, 29675.03, 1, 2, '2023-10-17T18:37:07.84', NULL),
    (7, 6, NULL, 1, 21688.702, 1, 2, '2023-10-20T18:40:49.763', NULL),
    (5, 4, NULL, 1, 18832.464, 1, 2, '2023-10-23T23:43:28.343', NULL),
    (10, 6, NULL, 1, 12554.976, 3, 2, '2023-10-23T23:44:33.1', NULL),
    (9, 6, NULL, 1, 14264.53, 4, 2, '2023-10-23T23:47:09.293', NULL),
    (1, 4, NULL, 1, 12554.976, 1, 2, '2023-10-24T23:48:26.193', NULL),
    (7, 6, NULL, 1, 12554.976, 1, 2, '2023-10-24T23:48:58.51', NULL),
    (2, 4, NULL, 1, 6277.488, 1, 2, '2023-10-25T23:53:45.717', NULL),
    (5, 4, NULL, 1, 22822.415, 1, 2, '2023-10-25T23:59:39.01', NULL),
    (9, 6, NULL, 1, 133555.842, 2, 2, '2023-10-25T00:00:28.377', NULL);

GO

INSERT INTO order_products
    (order_id, product_id, price, amount)
VALUES
    (1, 10, 4315.0, 1),
    (1, 22, 4795.0, 2),
    (2, 10, 4315.2, 1),
    (2, 11, 6235.9, 1),
    (2, 12, 5755.7, 1),
    (3, 12, 5755.7, 1),
    (3, 13, 3355.8, 1),
    (3, 14, 7675.5, 1),
    (3, 15, 8635.1, 1),
    (4, 14, 7675.5, 1),
    (4, 15, 8635.1, 1),
    (4, 16, 3500.0, 1),
    (4, 17, 4795.4, 1),
    (4, 18, 4315.2, 1),
    (4, 19, 7675.6, 1),
    (5, 16, 3500.0, 1),
    (5, 17, 4795.4, 1),
    (5, 18, 4315.2, 1),
    (6, 18, 4315.2, 1),
    (6, 19, 7675.6, 1),
    (6, 20, 6235.9, 1),
    (6, 21, 3355.8, 1),
    (7, 20, 6235.9, 1),
    (7, 21, 3355.8, 1),
    (7, 22, 5755.7, 1),
    (7, 23, 8635.1, 1),
    (7, 24, 3500.0, 1),
    (7, 25, 4795.4, 1),
    (8, 3, 3835.7, 1),
    (8, 5, 4795.2, 3),
    (9, 1, 2875.2, 1),
    (9, 2, 3355.4, 1),
    (9, 3, 3835.7, 2),
    (10, 1, 2875.2, 1),
    (10, 2, 3355.4, 1),
    (10, 3, 3835.7, 2),
    (11, 2, 3355.4, 1),
    (11, 3, 3835.7, 2),
    (11, 4, 4315.2, 1),
    (12, 29, 7675.2, 1),
    (12, 31, 2500.25, 1),
    (12, 32, 3500.0, 1),
    (13, 3, 3835.7, 1),
    (13, 22, 4795.9, 3),
    (14, 21, 4315.6, 1),
    (14, 22, 4795.9, 1),
    (14, 26, 6715.2, 3),
    (15, 4, 4315.2, 1),
    (15, 28, 8155.2, 1),
    (15, 32, 3500.0, 2),
    (16, 3, 3835.7, 1),
    (16, 5, 4795.2, 2),
    (17, 11, 5755.2, 3),
    (17, 13, 6715.3, 1),
    (17, 26, 6715.2, 2),
    (17, 28, 8155.2, 1),
    (18, 4, 4315.2, 1),
    (19, 1, 2875.2, 2),
    (20, 3, 3835.7, 1),
    (20, 5, 4795.2, 1),
    (20, 6, 5275.2, 2),
    (21, 2, 3355.4, 1),
    (21, 3, 3835.7, 1),
    (21, 6, 5275.2, 2),
    (22, 5, 4795.2, 1),
    (22, 6, 5275.2, 2),
    (22, 14, 7195.2, 2),
    (23, 3, 3835.7, 1),
    (23, 6, 5275.2, 1),
    (23, 8, 3355.9, 1),
    (23, 18, 6235.1, 2),
    (24, 2, 3355.4, 1),
    (24, 26, 6715.2, 1),
    (24, 28, 8155.2, 1),
    (25, 6, 5275.2, 3),
    (26, 6, 5275.2, 2),
    (27, 6, 5275.2, 1),
    (27, 8, 3355.9, 2),
    (28, 6, 5275.2, 2),
    (29, 6, 5275.2, 2),
    (30, 6, 5275.2, 1),
    (31, 3, 3835.7, 5),
    (32, 18, 6235.1, 18);

GO