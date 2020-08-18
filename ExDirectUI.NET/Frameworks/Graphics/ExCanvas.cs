﻿using ExDirectUI.NET.Frameworks.Graphics;
using ExDirectUI.NET.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDirectUI.NET.Frameworks.Graphics
{
    class ExCanvas : IDisposable
    {
        protected IntPtr m_hCanvas;

        public IntPtr Handle => m_hCanvas;

        public ExCanvas(ExSkin skin, int width, int height, int dwFlags)
        {
            m_hCanvas = (IntPtr)ExAPI._canvas_createfromexdui(skin.Handle, width, height, dwFlags);
        }

        public ExCanvas(ExControl obj, int uWidth, int uHeight, int dwFlags, out int nError)
        {
            m_hCanvas = (IntPtr)ExAPI._canvas_createfromobj(obj.Handle, uWidth, uHeight, dwFlags, out nError);
        }

        public void Dispose()
        {
            ExAPI._canvas_destroy(m_hCanvas);
            m_hCanvas = IntPtr.Zero;
        }

        public bool BeginDraw()
        {
            return ExAPI._canvas_begindraw(m_hCanvas);
        }

        public bool Blur(float fDeviation, ref int lpRc)
        {
            return ExAPI._canvas_blur(m_hCanvas, fDeviation, ref lpRc);
        }

        public bool CalcTextSize(ExFont font, string text, int dwLen, int dwDTFormat, int lParam, float layoutWidth, float layoutHeight, out float lpWidth, out float lpHeight)
        {
            return ExAPI._canvas_calctextsize(m_hCanvas, font.Handle, text, dwLen, dwDTFormat, lParam, layoutWidth, layoutHeight, out lpWidth, out lpHeight);
        }

        public bool Clear(int nColor)
        {
            return ExAPI._canvas_clear(m_hCanvas, nColor);
        }

        public bool ClipRect(int left, int top, int right, int bottom)
        {
            return ExAPI._canvas_cliprect(m_hCanvas, left, top, right, bottom);
        }

        public bool DrawRoundedRect(ExBrush brush, float left, float top, float right, float bottom, float radiusX, float radiusY, float strokeWidth, int strokeStyle)
        {
            return ExAPI._canvas_drawroundedrect(m_hCanvas, brush.Handle, left, top, right, bottom, radiusX, radiusY, strokeWidth, strokeStyle);
        }

        public bool DrawText(ExFont font, int crText, string lpwzText, int dwLen, int dwDTFormat, float left, float top, float right, float bottom)
        {
            return ExAPI._canvas_drawtext(m_hCanvas, font.Handle, crText, lpwzText, dwLen, dwDTFormat, left, top, right, bottom);
        }

        public bool DrawTextEx(ExFont font, int crText, ref int lpwzText, int dwLen, int dwDTFormat, float left, float top, float right, float bottom, int iGlowsize, int crShadow, int lParam, ref ExRect prclayout)
        {
            return ExAPI._canvas_drawtextex(m_hCanvas, font.Handle, crText, ref lpwzText, dwLen, dwDTFormat, left, top, right, bottom, iGlowsize, crShadow, lParam, ref prclayout);
        }

        public bool EndDraw()
        {
            return ExAPI._canvas_enddraw(m_hCanvas);
        }

        public bool FillEllipse(ExBrush brush, float x, float y, float radiusX, float radiusY)
        {
            return ExAPI._canvas_fillellipse(m_hCanvas, brush.Handle, x, y, radiusX, radiusY);
        }

        public int FillPath(ExPath path, ExBrush brush)
        {
            return ExAPI._canvas_fillpath(m_hCanvas, path.Handle, brush.Handle);
        }

        public bool FillRect(ExBrush brush, float left, float top, float right, float bottom)
        {
            return ExAPI._canvas_fillrect(m_hCanvas, brush.Handle, left, top, right, bottom);
        }

        public bool FillRegion(ExRegion region, ExBrush brush)
        {
            return ExAPI._canvas_fillregion(m_hCanvas, region.Handle, brush.Handle);
        }

        public bool DrawEllipse(ExBrush brush, float x, float y, float radiusX, float radiusY, float strokeWidth, int strokeStyle)
        {
            return ExAPI._canvas_drawellipse(m_hCanvas, brush.Handle, x, y, radiusX, radiusY, strokeWidth, strokeStyle);
        }

        public bool DrawImage(ExImg img, float left, float top, int alpha)
        {
            return ExAPI._canvas_drawimage(m_hCanvas, img.Handle, left, top, alpha);
        }

        public bool DrawImage(ExImg img, float dstLeft, float dstTop, float dstRight, float dstBottom, float srcLeft, float srcTop, float srcRight, float srcBottom, float gridPaddingLeft, float gridPaddingTop, float gridPaddingRight, float gridPaddingBottom, int dwFlags, int dwAlpha)
        {
            return ExAPI._canvas_drawimagefromgrid(m_hCanvas, img.Handle, dstLeft, dstTop, dstRight, dstBottom, srcLeft, srcTop, srcRight, srcBottom, gridPaddingLeft, gridPaddingTop, gridPaddingRight, gridPaddingBottom, dwFlags, dwAlpha);
        }

        public bool DrawRect(ExImg img, float left, float top, float right, float bottom, int alpha)
        {
            return ExAPI._canvas_drawimagerect(m_hCanvas, img.Handle, left, top, right, bottom, alpha);
        }

        public bool DrawRect(ExImg img, float dstLeft, float dstTop, float dstRight, float dstBottom, float srcLeft, float srcTop, float srcRight, float srcBottom, int alpha)
        {
            return ExAPI._canvas_drawimagerectrect(m_hCanvas, img.Handle, dstLeft, dstTop, dstRight, dstBottom, srcLeft, srcTop, srcRight, srcBottom, alpha);
        }

        public bool DrawLine(ExBrush brush, float x1, float y1, float x2, float y2, float strokeWidth, int strokeStyle)
        {
            return ExAPI._canvas_drawline(m_hCanvas, brush.Handle, x1, y1, x2, y2, strokeWidth, strokeStyle);
        }

        public int DrawPath(ExPath path, ExBrush brush)
        {
            return ExAPI._canvas_drawpath(m_hCanvas, path.Handle, brush.Handle);
        }

        public bool DrawRect(ExBrush brush, float left, float top, float right, float bottom, float strokeWidth, int strokeStyle)
        {
            return ExAPI._canvas_drawrect(m_hCanvas, brush.Handle, left, top, right, bottom, strokeWidth, strokeStyle);
        }

        public bool FillRoundedRect(ExBrush brush, float left, float top, float right, float bottom, float radiusX, float radiusY)
        {
            return ExAPI._canvas_fillroundedrect(m_hCanvas, brush.Handle, left, top, right, bottom, radiusX, radiusY);
        }

        public bool Flush()
        {
            return ExAPI._canvas_flush(m_hCanvas);
        }

        public int GetContext(int nType)
        {
            return ExAPI._canvas_getcontext(m_hCanvas, nType);
        }

        public int GetDC()
        {
            return ExAPI._canvas_getdc(m_hCanvas);
        }

        public bool GetSize(out int width, out int height)
        {
            return ExAPI._canvas_getsize(m_hCanvas, out width, out height);
        }

        public bool ReleaseDC()
        {
            return ExAPI._canvas_releasedc(m_hCanvas);
        }

        public bool ResetClip()
        {
            return ExAPI._canvas_resetclip(m_hCanvas);
        }

        public bool Resize(int width, int height, bool fCopy)
        {
            return ExAPI._canvas_resize(m_hCanvas, width, height, fCopy);
        }

        public bool RotateHue(float fAngle)
        {
            return ExAPI._canvas_rotate_hue(m_hCanvas, fAngle);
        }

        public bool SetAntiAlias(bool antialias)
        {
            return ExAPI._canvas_setantialias(m_hCanvas, antialias);
        }

        public bool SetImageAntiAlias(bool antialias)
        {
            return ExAPI._canvas_setimageantialias(m_hCanvas, antialias);
        }

        public bool SetTextAntiAliasMode(int textAntialiasMode)
        {
            return ExAPI._canvas_settextantialiasmode(m_hCanvas, textAntialiasMode);
        }

        public bool SetTransForm(ExMatrix matrix)
        {
            return ExAPI._canvas_settransform(m_hCanvas, matrix.Handle);
        }
    }
}
