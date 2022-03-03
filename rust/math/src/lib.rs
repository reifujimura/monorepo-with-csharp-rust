#[no_mangle]
pub extern "C" fn rust_add(a: i32, b: i32) -> i32 {
    a + b
}

#[repr(C)]
pub struct Vector2 {
    x: f64,
    y: f64,
}

#[no_mangle]
pub extern "C" fn rust_length(vector: Vector2) -> f64 {
    (vector.x.powf(2.0) + vector.y.powf(2.0)).sqrt()
}
