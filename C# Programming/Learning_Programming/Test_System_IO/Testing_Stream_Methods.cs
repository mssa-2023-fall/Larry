namespace LearnSystemIO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TryStreamReadMethod()
        {
            //arrange: create a 100 loop to build MemoryStream 0x00,0x01,0x02,0x03,....
            byte[] byteArr = new byte[100];
            for (byte i = 0; i < 100; i++)
            {
                byteArr[i] = (i);
            }
            Stream s = new MemoryStream(byteArr);
            //act: let's read first 5 bytes by using Stream.Read Method
            // Stream.Read signature (byte[] bufferToPopulate,int startingPosition, int numberOfBytes)
            byte[] bufferToPopulate = new byte[5];// create a 5 bytes array as the destination to stored bytes read

            int bytesRead = s.Read(bufferToPopulate, 0, 5); //call Stream.Read to read the first 5 bytes ** it will advance the pointer from 0 to 5

            Assert.AreEqual(bufferToPopulate[0], 0x00);
            Assert.AreEqual(bufferToPopulate[1], 0x01);
            Assert.AreEqual(bufferToPopulate[2], 0x02);
            Assert.AreEqual(bufferToPopulate[3], 0x03);
            Assert.AreEqual(bufferToPopulate[4], 0x04);
            Assert.AreEqual(bytesRead, 5);
        }
        [TestMethod]
        public void ConfirmStreamReadReturnValueIsBoundByTheNumberOfByteActuallyRead()
        {
            //arrange: create a 100 loop to build MemoryStream 0x00,0x01,0x02,0x03,....
            byte[] byteArr = new byte[100];
            for (byte i = 0; i < 100; i++)
            {
                byteArr[i] = (i);
            }
            Stream s = new MemoryStream(byteArr);
            //act: let's read first 5 bytes by using Stream.Read Method
            // Stream.Read signature (byte[] bufferToPopulate,int startingPosition, int numberOfBytes)
            byte[] bufferToPopulate = new byte[120];// create a 5 bytes array as the destination to stored bytes read

            int bytesRead = s.Read(bufferToPopulate, 0, 120); //call Stream.Read to read the first 5 bytes ** it will advance the pointer from 0 to 5

            Assert.AreEqual(bufferToPopulate[0], 0x00);
            Assert.AreEqual(bufferToPopulate[1], 0x01);
            Assert.AreEqual(bufferToPopulate[2], 0x02);
            Assert.AreEqual(bufferToPopulate[3], 0x03);
            Assert.AreEqual(bufferToPopulate[4], 0x04);
            Assert.AreEqual(bytesRead, 100);
        }

        [TestMethod]
        public void CreateANewMemoryStreamFromBytes()
        {
            //arrange: create a 100 loop to build MemoryStream 0x00,0x01,0x02,0x03,....
            byte[] byteArr = new byte[100];
            for (byte i = 0; i < 100; i++)
            {
                byteArr[i] = (i);
            }
            Stream s = new MemoryStream();//the Stream s is empty
            //Act write to Stream s using data in byteArr
            s.Write(byteArr, 0, 100);
            s.Position = 0;//reset the stream to the beginning of the stream
            //the position of stream is at 100 because we just Wrote 100 bytes
            Assert.IsTrue(s.CanWrite);
            Assert.IsTrue(s.CanSeek);
            Assert.IsTrue(s.CanRead);
            Assert.AreEqual(100, s.Length);
            Assert.AreEqual(0, s.Position);

            Assert.AreEqual(0, s.ReadByte());
            Assert.AreEqual(1, s.Position);
            Assert.AreEqual(1, s.ReadByte());
            Assert.AreEqual(10, s.Seek(10, 0));
            Assert.AreEqual(10, s.ReadByte());
        }
        [TestMethod]
        public void CreateANewFileStreamFromBytes()
        {
            //arrange: create a 100 loop to build MemoryStream 0x00,0x01,0x02,0x03,....
            byte[] byteArr = new byte[100];
            for (byte i = 0; i < 100; i++)
            {
                byteArr[i] = (i);
            }
            Stream s = new FileStream("out.bin", FileMode.OpenOrCreate);//the Stream s is empty
            //Act write to Stream s using data in byteArr
            s.Write(byteArr, 0, 100);
            s.Position = 0;//reset the stream to the beginning of the stream
            //the position of stream is at 100 because we just Wrote 100 bytes
            Assert.IsTrue(s.CanWrite);
            Assert.IsTrue(s.CanSeek);
            Assert.IsTrue(s.CanRead);
            Assert.AreEqual(100, s.Length);
            Assert.AreEqual(0, s.Position);

            Assert.AreEqual(0, s.ReadByte());
            Assert.AreEqual(1, s.Position);
            Assert.AreEqual(1, s.ReadByte());
            Assert.AreEqual(10, s.Seek(10, 0));
            Assert.AreEqual(10, s.ReadByte());
        }

    }
}