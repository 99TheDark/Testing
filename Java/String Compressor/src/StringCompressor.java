public class StringCompressor {

	public static byte[] toBytes(String str) {

		byte[] bytes = new byte[str.length()];
		char[] chars = str.toCharArray();

		for (int i = 0; i < chars.length; i++) {

			bytes[i] = (byte) (char) chars[i];

		}

		return bytes;

	}

	public static String fromBytes(byte[] bytes) {

		String str = "";

		for (byte b : bytes) {

			str += (char) b;

		}

		return str;

	}

}