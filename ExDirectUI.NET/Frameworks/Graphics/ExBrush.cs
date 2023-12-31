﻿using ExDirectUI.NET.Native;
using System;

namespace ExDirectUI.NET.Frameworks.Graphics
{
    public class ExBrush : IDisposable
    {
        protected IntPtr m_hBrush;
        protected int _color;

        public IntPtr Handle => m_hBrush;

        public ExBrush(int Color)
        {
            m_hBrush = (IntPtr)ExAPI._brush_create(Color);
            _color = Color;
        }

        public ExBrush(ExCanvas canvas)
        {
            m_hBrush = (IntPtr)ExAPI._brush_createfromcanvas(canvas.Handle);
        }

        public ExBrush(ExImage img)
        {
            m_hBrush = (IntPtr)ExAPI._brush_createfromimg(img.Handle);
        }

        public ExBrush(float cx, float cy, float off_x, float off_y, float radiusX, float radiusY, int arrStopPts, int cStopPts)
        {
            m_hBrush = (IntPtr)ExAPI._brush_createradial_ex(cx, cy, off_x, off_y, radiusX, radiusY, arrStopPts, cStopPts);
        }

        public ExBrush(IntPtr hBrush)
        {
            m_hBrush = hBrush;
        }

        public int Color
        {
            get
            {
                return _color;
            }
            set
            {
                ExAPI._brush_setcolor(m_hBrush, value);
            }
        }

        public ExMatrix TransFrom
        {
            set
            {
                ExAPI._brush_settransform(m_hBrush, value.Handle);
            }
        }

        public void Dispose()
        {
            ExAPI._brush_destroy(m_hBrush);
            m_hBrush = IntPtr.Zero;
        }
    }
}
