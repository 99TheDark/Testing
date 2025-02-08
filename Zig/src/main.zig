const std = @import("std");

const Cache = std.AutoHashMap(u32, u128);

pub fn fib_rec(n: u32, cache: *Cache) u128 {
    switch (n) {
        0 => return 0,
        1, 2 => return 1,
        else => {
            const value = cache.get(n);
            if (value) |v| {
                return v;
            } else {
                const result = fib_rec(n - 1, cache) + fib_rec(n - 2, cache);
                cache.put(n, result) catch {};
                return result;
            }
        },
    }
}

const root2 = std.math.sqrt(5.0);
const phi = (1.0 + root2) / 2.0;

pub fn fib_phi(n: u32) u128 {
    const power: f64 = @floatFromInt(n);
    const result: f64 = std.math.pow(f64, phi, power) / root2;
    return @intFromFloat(result);
}

pub fn main() !void {
    const allocator = std.heap.page_allocator;
    var cache = Cache.init(allocator);

    // Any bigger and rounding errors cause it to break
    const n = 71;
    std.debug.print("fib_rec({}) = {}\nfib_rec({}) = {}\n", .{ n, fib_rec(n, &cache), n, fib_phi(n) });
}
