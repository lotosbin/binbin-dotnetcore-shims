using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xunit;
using Xunit.Abstractions;

namespace unittests.System.Web {
    public class HttpServerUtilityTests {
        private readonly ITestOutputHelper _output;

        public HttpServerUtilityTests(ITestOutputHelper output) {
            _output = output;
        }

        [Fact]
        public void UrlTokenEncode() {
            var result = Encoding.Unicode.GetBytes("sldfsld");
            var s = HttpServerUtility.UrlTokenEncode(result);
            _output.WriteLine(s);
            Assert.True(false);
        }
        [Fact]
        public void UrlTokenDecode() {
            var urlTokenDecode = HttpServerUtility.UrlTokenDecode("cwBsAGQAZgBzAGwAZAA1");
            var s = Encoding.Unicode.GetString(urlTokenDecode);
            _output.WriteLine(s);
            Assert.True(false);
        }
    }
}
