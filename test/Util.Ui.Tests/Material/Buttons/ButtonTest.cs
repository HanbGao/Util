﻿using System.IO;
using System.Text.Encodings.Web;
using Util.Helpers;
using Util.Ui.Extensions;
using Util.Ui.Material.Buttons;
using Util.Ui.Material.Enums;
using Util.Ui.Material.Extensions;
using Xunit;
using Xunit.Abstractions;

namespace Util.Ui.Tests.Material.Buttons {
    /// <summary>
    /// 按钮测试
    /// </summary>
    public class ButtonTest {
        /// <summary>
        /// 输出工具
        /// </summary>
        private readonly ITestOutputHelper _output;
        /// <summary>
        /// 按钮
        /// </summary>
        private readonly Button _component;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public ButtonTest( ITestOutputHelper output ) {
            _output = output;
            _component = new Button();
        }

        /// <summary>
        /// 获取结果
        /// </summary>
        private string GetResult( Button component ) {
            component.WriteTo( new StringWriter(), HtmlEncoder.Default );
            var result = component.ToString();
            _output.WriteLine( result );
            return result;
        }

        /// <summary>
        /// 测试默认输出
        /// </summary>
        [Fact]
        public void TestDefault() {
            var result = new String();
            result.Append( "<mat-button-wrapper></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component ) );
        }

        /// <summary>
        /// 测试添加标识
        /// </summary>
        [Fact]
        public void TestId() {
            var result = new String();
            result.Append( "<mat-button-wrapper #a=\"\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Id( "a" ) ) );
        }

        /// <summary>
        /// 测试文本
        /// </summary>
        [Fact]
        public void TestText() {
            var result = new String();
            result.Append( "<mat-button-wrapper text=\"a\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Text( "a" ) ) );
        }

        /// <summary>
        /// 测试设置重置类型
        /// </summary>
        [Fact]
        public void TestReset() {
            var result = new String();
            result.Append( "<mat-button-wrapper type=\"reset\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Reset() ) );
        }

        /// <summary>
        /// 测试设置提交类型
        /// </summary>
        [Fact]
        public void TestSubmit() {
            var result = new String();
            result.Append( "<mat-button-wrapper type=\"submit\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Submit() ) );
        }

        /// <summary>
        /// 测试样式
        /// </summary>
        [Fact]
        public void TestStyle() {
            var result = new String();
            result.Append( "<mat-button-wrapper style=\"mat-fab\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Style( ButtonStyle.Fab ) ) );
        }

        /// <summary>
        /// 测试颜色
        /// </summary>
        [Fact]
        public void TestColor() {
            var result = new String();
            result.Append( "<mat-button-wrapper color=\"primary\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Color( Color.Primary ) ) );
        }

        /// <summary>
        /// 测试禁用
        /// </summary>
        [Fact]
        public void TestDisable() {
            var result = new String();
            result.Append( "<mat-button-wrapper [disabled]=\"true\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Disable() ) );
        }

        /// <summary>
        /// 测试禁用
        /// </summary>
        [Fact]
        public void TestDisable_String() {
            var result = new String();
            result.Append( "<mat-button-wrapper [disabled]=\"a\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Disable("a") ) );
        }

        /// <summary>
        /// 测试提示
        /// </summary>
        [Fact]
        public void TestTooltip() {
            var result = new String();
            result.Append( "<mat-button-wrapper tooltip=\"a\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.Tooltip( "a" ) ) );
        }

        /// <summary>
        /// 测试单击事件
        /// </summary>
        [Fact]
        public void TestOnClick() {
            var result = new String();
            result.Append( "<mat-button-wrapper (onClick)=\"a\"></mat-button-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( _component.OnClick( "a" ) ) );
        }
    }
}
