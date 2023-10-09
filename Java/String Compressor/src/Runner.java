public class Runner {

	public static void main(String[] args) {

		byte[] bytes = StringCompressor.toBytes("Hello world! 🫠");
		
		for(byte b : bytes) {
			System.out.print(b + " ");
		}
		System.out.println();
		
		// Expected output:
		// 72 101 108 108 111 32 119 111 114 108 100 33 
				
	}

}