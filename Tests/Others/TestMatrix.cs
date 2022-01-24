using NUnit.Framework;
using static Unity.Mathematics.FixedPoint.MathFp;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.FixedPoint.Tests
{
    [TestFixture]
    class TestMatrix
    {
        [TestCompiler]
        public static void Fp2x2_constructor_columns()
        {
            Fp2x2 a = Fp2x2(Fp2((Fp)(1.0f), (Fp)(2.0f)),
                Fp2((Fp)(3.0f), (Fp)(4.0f)));

            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(2.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(3.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(4.0f), a.c1.y);
        }

        [TestCompiler]
        public static void Fp3x3_constructor_columns()
        {
            Fp3x3 a = Fp3x3(Fp3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f)),
                Fp3((Fp)(4.0f), (Fp)(5.0f), (Fp)(6.0f)),
                Fp3((Fp)(7.0f), (Fp)(8.0f), (Fp)(9.0f)));

            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(2.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(3.0f), a.c0.z);
            TestUtils.AreEqual((Fp)(4.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(5.0f), a.c1.y);
            TestUtils.AreEqual((Fp)(6.0f), a.c1.z);
            TestUtils.AreEqual((Fp)(7.0f), a.c2.x);
            TestUtils.AreEqual((Fp)(8.0f), a.c2.y);
            TestUtils.AreEqual((Fp)(9.0f), a.c2.z);
        }

        [TestCompiler]
        public static void Fp4x4_constructor_columns()
        {
            Fp4x4 a = Fp4x4(Fp4((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f)),
                Fp4((Fp)(5.0f), (Fp)(6.0f), (Fp)(7.0f), (Fp)(8.0f)),
                Fp4((Fp)(9.0f), (Fp)(10.0f), (Fp)(11.0f), (Fp)(12.0f)),
                Fp4((Fp)(13.0f), (Fp)(14.0f), (Fp)(15.0f), (Fp)(16.0f)));

            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(2.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(3.0f), a.c0.z);
            TestUtils.AreEqual((Fp)(4.0f), a.c0.w);
            TestUtils.AreEqual((Fp)(5.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(6.0f), a.c1.y);
            TestUtils.AreEqual((Fp)(7.0f), a.c1.z);
            TestUtils.AreEqual((Fp)(8.0f), a.c1.w);
            TestUtils.AreEqual((Fp)(9.0f), a.c2.x);
            TestUtils.AreEqual((Fp)(10.0f), a.c2.y);
            TestUtils.AreEqual((Fp)(11.0f), a.c2.z);
            TestUtils.AreEqual((Fp)(12.0f), a.c2.w);
            TestUtils.AreEqual((Fp)(13.0f), a.c3.x);
            TestUtils.AreEqual((Fp)(14.0f), a.c3.y);
            TestUtils.AreEqual((Fp)(15.0f), a.c3.z);
            TestUtils.AreEqual((Fp)(16.0f), a.c3.w);
        }

        [TestCompiler]
        public static void Fp2x2_constructor_scalars()
        {
            Fp2x2 a = Fp2x2((Fp)(1.0f), (Fp)(2.0f),
                (Fp)(3.0f), (Fp)(4.0f));

            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(2.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(3.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(4.0f), a.c1.y);
        }

        [TestCompiler]
        public static void Fp3x3_constructor_scalars()
        {
            Fp3x3 a = Fp3x3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f),
                (Fp)(4.0f), (Fp)(5.0f), (Fp)(6.0f),
                (Fp)(7.0f), (Fp)(8.0f), (Fp)(9.0f));

            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(2.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(3.0f), a.c2.x);
            TestUtils.AreEqual((Fp)(4.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(5.0f), a.c1.y);
            TestUtils.AreEqual((Fp)(6.0f), a.c2.y);
            TestUtils.AreEqual((Fp)(7.0f), a.c0.z);
            TestUtils.AreEqual((Fp)(8.0f), a.c1.z);
            TestUtils.AreEqual((Fp)(9.0f), a.c2.z);
        }

        [TestCompiler]
        public static void Fp4x4_constructor_scalars()
        {
            Fp4x4 a = Fp4x4((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f),
                (Fp)(5.0f), (Fp)(6.0f), (Fp)(7.0f), (Fp)(8.0f),
                (Fp)(9.0f), (Fp)(10.0f), (Fp)(11.0f), (Fp)(12.0f),
                (Fp)(13.0f), (Fp)(14.0f), (Fp)(15.0f), (Fp)(16.0f));

            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(2.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(3.0f), a.c2.x);
            TestUtils.AreEqual((Fp)(4.0f), a.c3.x);
            TestUtils.AreEqual((Fp)(5.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(6.0f), a.c1.y);
            TestUtils.AreEqual((Fp)(7.0f), a.c2.y);
            TestUtils.AreEqual((Fp)(8.0f), a.c3.y);
            TestUtils.AreEqual((Fp)(9.0f), a.c0.z);
            TestUtils.AreEqual((Fp)(10.0f), a.c1.z);
            TestUtils.AreEqual((Fp)(11.0f), a.c2.z);
            TestUtils.AreEqual((Fp)(12.0f), a.c3.z);
            TestUtils.AreEqual((Fp)(13.0f), a.c0.w);
            TestUtils.AreEqual((Fp)(14.0f), a.c1.w);
            TestUtils.AreEqual((Fp)(15.0f), a.c2.w);
            TestUtils.AreEqual((Fp)(16.0f), a.c3.w);
        }

        [TestCompiler]
        public static void Fp4x4_constructor_Fp3x3()
        {
            Fp3x3 rot = Fp3x3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f),
                (Fp)(4.0f), (Fp)(5.0f), (Fp)(6.0f),
                (Fp)(7.0f), (Fp)(8.0f), (Fp)(9.0f));
            Fp3 pos = Fp3((Fp)(10.0f), (Fp)(11.0f), (Fp)(12.0f));
            Fp4x4 m = Fp4x4(rot, pos);

            Fp4x4 r = Fp4x4((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f), (Fp)(10.0f),
                (Fp)(4.0f), (Fp)(5.0f), (Fp)(6.0f), (Fp)(11.0f),
                (Fp)(7.0f), (Fp)(8.0f), (Fp)(9.0f), (Fp)(12.0f),
                (Fp)(0.0f), (Fp)(0.0f), (Fp)(0.0f), (Fp)(1.0f));
            TestUtils.AreEqual(r, m);
        }


        [TestCompiler]
        public static void Fp3x3_constructor_quaternion()
        {
            Fp3x3 m = Fp3x3(normalize(QuaternionFp((Fp)(1.0f), (Fp)(2.5f), (Fp)(3.3f), (Fp)(4.6f))));

            Fp3x3 r = Fp3x3((Fp)(0.12774f), (Fp)(-0.64529f), (Fp)(0.75318f),
                (Fp)(0.89975f), (Fp)(0.39491f), (Fp)(0.18575f),
                (Fp)(-0.41730f), (Fp)(0.65394f), (Fp)(0.63104f));

            TestUtils.AreEqual(r, m, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp4x4_constructor_quaternion_position()
        {
            Fp4x4 m = Fp4x4(normalize(QuaternionFp((Fp)(1.0f), (Fp)(2.5f), (Fp)(3.3f), (Fp)(4.6f))), Fp3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f)));

            Fp4x4 r = Fp4x4((Fp)(0.12774f), (Fp)(-0.64529f), (Fp)(0.75318f), (Fp)(1.0f),
                (Fp)(0.89975f), (Fp)(0.39491f), (Fp)(0.18575f), (Fp)(2.0f),
                (Fp)(-0.41730f), (Fp)(0.65394f), (Fp)(0.63104f), (Fp)(3.0f),
                (Fp)(0.0f), (Fp)(0.0f), (Fp)(0.0f), (Fp)(1.0f));

            TestUtils.AreEqual(r, m, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp2x2_identity()
        {
            Fp2x2 a = Fp2x2.identity;
            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(1.0f), a.c1.y);
        }

        [TestCompiler]
        public static void Fp3x3_identity()
        {
            Fp3x3 a = Fp3x3.identity;
            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c2.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(1.0f), a.c1.y);
            TestUtils.AreEqual((Fp)(0.0f), a.c2.y);
            TestUtils.AreEqual((Fp)(0.0f), a.c0.z);
            TestUtils.AreEqual((Fp)(0.0f), a.c1.z);
            TestUtils.AreEqual((Fp)(1.0f), a.c2.z);
        }

        [TestCompiler]
        public static void Fp4x4_identity()
        {
            Fp4x4 a = Fp4x4.identity;
            TestUtils.AreEqual((Fp)(1.0f), a.c0.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c1.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c2.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c3.x);
            TestUtils.AreEqual((Fp)(0.0f), a.c0.y);
            TestUtils.AreEqual((Fp)(1.0f), a.c1.y);
            TestUtils.AreEqual((Fp)(0.0f), a.c2.y);
            TestUtils.AreEqual((Fp)(0.0f), a.c3.y);
            TestUtils.AreEqual((Fp)(0.0f), a.c0.z);
            TestUtils.AreEqual((Fp)(0.0f), a.c1.z);
            TestUtils.AreEqual((Fp)(1.0f), a.c2.z);
            TestUtils.AreEqual((Fp)(0.0f), a.c3.z);
            TestUtils.AreEqual((Fp)(0.0f), a.c0.w);
            TestUtils.AreEqual((Fp)(0.0f), a.c1.w);
            TestUtils.AreEqual((Fp)(0.0f), a.c2.w);
            TestUtils.AreEqual((Fp)(1.0f), a.c3.w);
        }

        [TestCompiler]
        public static void Fp2x2_rotate()
        {
            Fp epsilon = (Fp)(0.0001f);
            Fp angle = (Fp)(10.3f);
            Fp2x2 m = Fp2x2.Rotate(angle);
            TestUtils.AreEqual(cos(angle), m.c0.x, epsilon);
            TestUtils.AreEqual(sin(angle), m.c0.y, epsilon);
            TestUtils.AreEqual(-sin(angle), m.c1.x, epsilon);
            TestUtils.AreEqual(cos(angle), m.c1.y, epsilon);
        }

        [TestCompiler]
        public static void Fp3x3_axis_angle()
        {
            Fp3 axis = normalize(Fp3((Fp)(1.1f), (Fp)(2.3f), (Fp)(-3.6f)));
            Fp angle = (Fp)(2.7f);

            Fp3x3 r = Fp3x3(QuaternionFp.AxisAngle(axis, angle));
            Fp3x3 m = Fp3x3.AxisAngle(axis, angle);
            TestUtils.AreEqual(r, m, (Fp)(0.00001f));
        }

        [TestCompiler]
        public static void Fp3x3_axis_angle_consistency()
        {
            TestUtils.AreEqual(Fp3x3.RotateX((Fp)(1.0f)), Fp3x3.AxisAngle(Fp3(1, 0, 0), (Fp)(1.0f)), (Fp)(0.001f));
            TestUtils.AreEqual(Fp3x3.RotateY((Fp)(1.0f)), Fp3x3.AxisAngle(Fp3(0, 1, 0), (Fp)(1.0f)), (Fp)(0.001f));
            TestUtils.AreEqual(Fp3x3.RotateZ((Fp)(1.0f)), Fp3x3.AxisAngle(Fp3(0, 0, 1), (Fp)(1.0f)), (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp3x3_rotate_x()
        {
            Fp epsilon = (Fp)(0.0001f);
            Fp angle = (Fp)(10.3f);
            Fp3x3 m = Fp3x3.RotateX(angle);
            TestUtils.AreEqual((Fp)(1.0f), m.c0.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.x, epsilon);
            TestUtils.AreEqual(cos(angle), m.c1.y, epsilon);
            TestUtils.AreEqual(sin(angle), m.c1.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.x, epsilon);
            TestUtils.AreEqual(-sin(angle), m.c2.y, epsilon);
            TestUtils.AreEqual(cos(angle), m.c2.z, epsilon);
        }

        [TestCompiler]
        public static void Fp3x3_rotate_y()
        {
            Fp epsilon = (Fp)(0.0001f);
            Fp angle = (Fp)(10.3f);
            Fp3x3 m = Fp3x3.RotateY(angle);
            TestUtils.AreEqual(cos(angle), m.c0.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.y, epsilon);
            TestUtils.AreEqual(-sin(angle), m.c0.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.x, epsilon);
            TestUtils.AreEqual((Fp)(1.0f), m.c1.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.z, epsilon);
            TestUtils.AreEqual(sin(angle), m.c2.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.y, epsilon);
            TestUtils.AreEqual(cos(angle), m.c2.z, epsilon);
        }

        [TestCompiler]
        public static void Fp3x3_rotate_z()
        {
            Fp epsilon = (Fp)(0.0001f);
            Fp angle = (Fp)(10.3f);
            Fp3x3 m = Fp3x3.RotateZ(angle);
            TestUtils.AreEqual(cos(angle), m.c0.x, epsilon);
            TestUtils.AreEqual(sin(angle), m.c0.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.z, epsilon);
            TestUtils.AreEqual(-sin(angle), m.c1.x, epsilon);
            TestUtils.AreEqual(cos(angle), m.c1.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.y, epsilon);
            TestUtils.AreEqual((Fp)(1.0f), m.c2.z, epsilon);
        }

        [TestCompiler]
        public static void Fp3x3_rotate_x_handedness()
        {
            Fp3 a = Fp3((Fp)(0.0f), (Fp)(0.3f), (Fp)(0.7f));
            Fp3x3 m = Fp3x3.RotateX((Fp)(0.3f));
            Fp3 b = mul(m, a);
            Fp w = cross(a, b).x;
            TestUtils.AreEqual(w > (Fp)(0.0f), true);
        }


        [TestCompiler]
        public static void Fp3x3_rotate_y_handedness()
        {
            Fp3 a = Fp3((Fp)(0.3f), (Fp)(0.0f), (Fp)(0.7f));
            Fp3x3 m = Fp3x3.RotateY((Fp)(0.3f));
            Fp3 b = mul(m, a);
            Fp w = cross(a, b).y;
            TestUtils.AreEqual(w > (Fp)(0.0f), true);
        }

        [TestCompiler]
        public static void Fp3x3_rotate_z_handedness()
        {
            Fp3 a = Fp3((Fp)(0.3f), (Fp)(0.7f), (Fp)(0.0f));
            Fp3x3 m = Fp3x3.RotateZ((Fp)(0.3f));
            Fp3 b = mul(m, a);
            Fp w = cross(a, b).z;
            TestUtils.AreEqual(w > (Fp)(0.0f), true);
        }

        [TestCompiler]
        public static void Fp4x4_axis_angle()
        {
            Fp3 axis = normalize(Fp3((Fp)(1.1f), (Fp)(2.3f), (Fp)(-3.6f)));
            Fp angle = (Fp)(2.7f);

            Fp4x4 r = Fp4x4(QuaternionFp.AxisAngle(axis, angle), Fp3.zero);
            Fp4x4 m = Fp4x4.AxisAngle(axis, angle);
            TestUtils.AreEqual(r, m, (Fp)(0.00001f));
        }

        [TestCompiler]
        public static void Fp4x4_axis_angle_consistency()
        {
            TestUtils.AreEqual(Fp4x4.RotateX((Fp)(1.0f)), Fp4x4.AxisAngle(Fp3(1, 0, 0), (Fp)(1.0f)), (Fp)(0.001f));
            TestUtils.AreEqual(Fp4x4.RotateY((Fp)(1.0f)), Fp4x4.AxisAngle(Fp3(0, 1, 0), (Fp)(1.0f)), (Fp)(0.001f));
            TestUtils.AreEqual(Fp4x4.RotateZ((Fp)(1.0f)), Fp4x4.AxisAngle(Fp3(0, 0, 1), (Fp)(1.0f)), (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp4x4_rotate_x()
        {
            Fp epsilon = (Fp)(0.0001f);
            Fp angle = (Fp)(10.3f);
            Fp4x4 m = Fp4x4.RotateX(angle);
            TestUtils.AreEqual((Fp)(1.0f), m.c0.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.w, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.x, epsilon);
            TestUtils.AreEqual(cos(angle), m.c1.y, epsilon);
            TestUtils.AreEqual(sin(angle), m.c1.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.w, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.x, epsilon);
            TestUtils.AreEqual(-sin(angle), m.c2.y, epsilon);
            TestUtils.AreEqual(cos(angle), m.c2.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.w, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.z, epsilon);
            TestUtils.AreEqual((Fp)(1.0f), m.c3.w, epsilon);
        }

        [TestCompiler]
        public static void Fp4x4_rotate_y()
        {
            Fp epsilon = (Fp)(0.0001f);
            Fp angle = (Fp)(10.3f);
            Fp4x4 m = Fp4x4.RotateY(angle);
            TestUtils.AreEqual(cos(angle), m.c0.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.y, epsilon);
            TestUtils.AreEqual(-sin(angle), m.c0.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.w, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.x, epsilon);
            TestUtils.AreEqual((Fp)(1.0f), m.c1.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.w, epsilon);
            TestUtils.AreEqual(sin(angle), m.c2.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.y, epsilon);
            TestUtils.AreEqual(cos(angle), m.c2.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.w);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.x);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.y);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.z);
            TestUtils.AreEqual((Fp)(1.0f), m.c3.w);
        }

        [TestCompiler]
        public static void Fp4x4_rotate_z()
        {
            Fp epsilon = (Fp)(0.0001f);
            Fp angle = (Fp)(10.3f);
            Fp4x4 m = Fp4x4.RotateZ(angle);
            TestUtils.AreEqual(cos(angle), m.c0.x, epsilon);
            TestUtils.AreEqual(sin(angle), m.c0.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c0.w, epsilon);
            TestUtils.AreEqual(-sin(angle), m.c1.x, epsilon);
            TestUtils.AreEqual(cos(angle), m.c1.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c1.w, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.y, epsilon);
            TestUtils.AreEqual((Fp)(1.0f), m.c2.z, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c2.w, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.x, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.y, epsilon);
            TestUtils.AreEqual((Fp)(0.0f), m.c3.z, epsilon);
            TestUtils.AreEqual((Fp)(1.0f), m.c3.w, epsilon);
        }

        [TestCompiler]
        public static void Fp4x4_rotate_x_handedness()
        {
            Fp3 a = Fp3((Fp)(0.0f), (Fp)(0.3f), (Fp)(0.7f));
            Fp4x4 m = Fp4x4.RotateX((Fp)(0.3f));
            Fp3 b = rotate(m, a);
            Fp w = cross(a, b).x;
            TestUtils.AreEqual(w > (Fp)(0.0f), true);
        }


        [TestCompiler]
        public static void Fp4x4_rotate_y_handedness()
        {
            Fp3 a = Fp3((Fp)(0.3f), (Fp)(0.0f), (Fp)(0.7f));
            Fp4x4 m = Fp4x4.RotateY((Fp)(0.3f));
            Fp3 b = rotate(m, a);
            Fp w = cross(a, b).y;
            TestUtils.AreEqual(w > (Fp)(0.0f), true);
        }

        [TestCompiler]
        public static void Fp4x4_rotate_z_handedness()
        {
            Fp3 a = Fp3((Fp)(0.3f), (Fp)(0.7f), (Fp)(0.0f));
            Fp4x4 m = Fp4x4.RotateZ((Fp)(0.3f));
            Fp3 b = rotate(m, a);
            Fp w = cross(a, b).z;
            TestUtils.AreEqual(w > (Fp)(0.0f), true);
        }


        // rotation by (-50, 28, 39) degrees from Max
        static internal readonly Fp3 test_angles = MathFp.radians(Fp3((Fp)(-50.0f), (Fp)(28.0f), (Fp)(39.0f)));

        static internal readonly Fp3x3 test3x3_xyz = new Fp3x3((Fp)(0.686179155968f), (Fp)(-0.684009078513f), (Fp)(-0.247567660300f),
            (Fp)(0.555656924414f), (Fp)(0.273213475262f), (Fp)(0.785238676636f),
            (Fp)(-0.469471562786f), (Fp)(-0.676377097075f), (Fp)(0.567547772692f));

        static internal readonly Fp3x3 test3x3_xzy = new Fp3x3((Fp)(0.686179155968f), (Fp)(-0.716805468125f), (Fp)(-0.123887395569f),
            (Fp)(0.629320391050f), (Fp)(0.499539794942f), (Fp)(0.595328345266f),
            (Fp)(-0.364847929038f), (Fp)(-0.486466765705f), (Fp)(0.793874092373f));

        static internal readonly Fp3x3 test3x3_yxz = new Fp3x3((Fp)(0.912505475649f), (Fp)(-0.404519349890f), (Fp)(-0.0608099701904f),
            (Fp)(0.276167195792f), (Fp)(0.499539794942f), (Fp)(0.8210917568930f),
            (Fp)(-0.301770503659f), (Fp)(-0.766044443119f), (Fp)(0.5675477726920f));

        static internal readonly Fp3x3 test3x3_yzx = new Fp3x3((Fp)(0.68617915596800f), (Fp)(-0.629320391050f), (Fp)(0.364847929038f),
            (Fp)(-0.00246669562435f), (Fp)(0.499539794942f), (Fp)(0.866287428445f),
            (Fp)(-0.72742840288700f), (Fp)(-0.595328345266f), (Fp)(0.341221453011f));

        static internal readonly Fp3x3 test3x3_zxy = new Fp3x3((Fp)(0.459852836288f), (Fp)(-0.835146653037f), (Fp)(0.301770503659f),
            (Fp)(0.404519349890f), (Fp)(0.499539794942f), (Fp)(0.766044443119f),
            (Fp)(-0.790505828266f), (Fp)(-0.230195701935f), (Fp)(0.567547772692f));

        static internal readonly Fp3x3 test3x3_zyx = new Fp3x3((Fp)(0.686179155968f), (Fp)(-0.555656924414f), (Fp)(0.469471562786f),
            (Fp)(0.125029621267f), (Fp)(0.725866114623f), (Fp)(0.676377097075f),
            (Fp)(-0.716607116711f), (Fp)(-0.405418013897f), (Fp)(0.567547772692f));


        static internal readonly Fp4x4 test4x4_xyz = new Fp4x4(test3x3_xyz, new Fp3(0, 0, 0));
        static internal readonly Fp4x4 test4x4_xzy = new Fp4x4(test3x3_xzy, new Fp3(0, 0, 0));
        static internal readonly Fp4x4 test4x4_yxz = new Fp4x4(test3x3_yxz, new Fp3(0, 0, 0));
        static internal readonly Fp4x4 test4x4_yzx = new Fp4x4(test3x3_yzx, new Fp3(0, 0, 0));
        static internal readonly Fp4x4 test4x4_zxy = new Fp4x4(test3x3_zxy, new Fp3(0, 0, 0));
        static internal readonly Fp4x4 test4x4_zyx = new Fp4x4(test3x3_zyx, new Fp3(0, 0, 0));


        [TestCompiler]
        public static void Fp3x3_euler()
        {
            Fp3x3 m0_xyz = Fp3x3.EulerXYZ(test_angles);
            Fp3x3 m0_xzy = Fp3x3.EulerXZY(test_angles);
            Fp3x3 m0_yxz = Fp3x3.EulerYXZ(test_angles);
            Fp3x3 m0_yzx = Fp3x3.EulerYZX(test_angles);
            Fp3x3 m0_zxy = Fp3x3.EulerZXY(test_angles);
            Fp3x3 m0_zyx = Fp3x3.EulerZYX(test_angles);

            Fp3x3 m1 = Fp3x3.Euler(test_angles);
            Fp3x3 m1_xyz = Fp3x3.Euler(test_angles, RotationOrder.XYZ);
            Fp3x3 m1_xzy = Fp3x3.Euler(test_angles, RotationOrder.XZY);
            Fp3x3 m1_yxz = Fp3x3.Euler(test_angles, RotationOrder.YXZ);
            Fp3x3 m1_yzx = Fp3x3.Euler(test_angles, RotationOrder.YZX);
            Fp3x3 m1_zxy = Fp3x3.Euler(test_angles, RotationOrder.ZXY);
            Fp3x3 m1_zyx = Fp3x3.Euler(test_angles, RotationOrder.ZYX);


            Fp3x3 m2_xyz = Fp3x3.EulerXYZ(test_angles.x, test_angles.y, test_angles.z);
            Fp3x3 m2_xzy = Fp3x3.EulerXZY(test_angles.x, test_angles.y, test_angles.z);
            Fp3x3 m2_yxz = Fp3x3.EulerYXZ(test_angles.x, test_angles.y, test_angles.z);
            Fp3x3 m2_yzx = Fp3x3.EulerYZX(test_angles.x, test_angles.y, test_angles.z);
            Fp3x3 m2_zxy = Fp3x3.EulerZXY(test_angles.x, test_angles.y, test_angles.z);
            Fp3x3 m2_zyx = Fp3x3.EulerZYX(test_angles.x, test_angles.y, test_angles.z);

            Fp3x3 m3 = Fp3x3.Euler(test_angles.x, test_angles.y, test_angles.z);
            Fp3x3 m3_xyz = Fp3x3.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            Fp3x3 m3_xzy = Fp3x3.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            Fp3x3 m3_yxz = Fp3x3.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            Fp3x3 m3_yzx = Fp3x3.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            Fp3x3 m3_zxy = Fp3x3.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            Fp3x3 m3_zyx = Fp3x3.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);


            TestUtils.AreEqual(test3x3_xyz, m0_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yzx, m0_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zxy, m0_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_xzy, m0_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yxz, m0_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zyx, m0_zyx, (Fp)(0.0001f));

            TestUtils.AreEqual(test3x3_zxy, m1, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_xyz, m1_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yzx, m1_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zxy, m1_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_xzy, m1_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yxz, m1_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zyx, m1_zyx, (Fp)(0.0001f));


            TestUtils.AreEqual(test3x3_xyz, m2_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yzx, m2_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zxy, m2_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_xzy, m2_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yxz, m2_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zyx, m2_zyx, (Fp)(0.0001f));

            TestUtils.AreEqual(test3x3_zxy, m3, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_xyz, m3_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yzx, m3_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zxy, m3_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_xzy, m3_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_yxz, m3_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test3x3_zyx, m3_zyx, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp4x4_euler()
        {
            Fp4x4 m0_xyz = Fp4x4.EulerXYZ(test_angles);
            Fp4x4 m0_xzy = Fp4x4.EulerXZY(test_angles);
            Fp4x4 m0_yxz = Fp4x4.EulerYXZ(test_angles);
            Fp4x4 m0_yzx = Fp4x4.EulerYZX(test_angles);
            Fp4x4 m0_zxy = Fp4x4.EulerZXY(test_angles);
            Fp4x4 m0_zyx = Fp4x4.EulerZYX(test_angles);

            Fp4x4 m1 = Fp4x4.Euler(test_angles);
            Fp4x4 m1_xyz = Fp4x4.Euler(test_angles, RotationOrder.XYZ);
            Fp4x4 m1_xzy = Fp4x4.Euler(test_angles, RotationOrder.XZY);
            Fp4x4 m1_yxz = Fp4x4.Euler(test_angles, RotationOrder.YXZ);
            Fp4x4 m1_yzx = Fp4x4.Euler(test_angles, RotationOrder.YZX);
            Fp4x4 m1_zxy = Fp4x4.Euler(test_angles, RotationOrder.ZXY);
            Fp4x4 m1_zyx = Fp4x4.Euler(test_angles, RotationOrder.ZYX);


            Fp4x4 m2_xyz = Fp4x4.EulerXYZ(test_angles.x, test_angles.y, test_angles.z);
            Fp4x4 m2_xzy = Fp4x4.EulerXZY(test_angles.x, test_angles.y, test_angles.z);
            Fp4x4 m2_yxz = Fp4x4.EulerYXZ(test_angles.x, test_angles.y, test_angles.z);
            Fp4x4 m2_yzx = Fp4x4.EulerYZX(test_angles.x, test_angles.y, test_angles.z);
            Fp4x4 m2_zxy = Fp4x4.EulerZXY(test_angles.x, test_angles.y, test_angles.z);
            Fp4x4 m2_zyx = Fp4x4.EulerZYX(test_angles.x, test_angles.y, test_angles.z);

            Fp4x4 m3 = Fp4x4.Euler(test_angles.x, test_angles.y, test_angles.z);
            Fp4x4 m3_xyz = Fp4x4.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            Fp4x4 m3_xzy = Fp4x4.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            Fp4x4 m3_yxz = Fp4x4.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            Fp4x4 m3_yzx = Fp4x4.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            Fp4x4 m3_zxy = Fp4x4.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            Fp4x4 m3_zyx = Fp4x4.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);


            TestUtils.AreEqual(test4x4_xyz, m0_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yzx, m0_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zxy, m0_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_xzy, m0_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yxz, m0_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zyx, m0_zyx, (Fp)(0.0001f));

            TestUtils.AreEqual(test4x4_zxy, m1, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_xyz, m1_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yzx, m1_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zxy, m1_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_xzy, m1_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yxz, m1_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zyx, m1_zyx, (Fp)(0.0001f));


            TestUtils.AreEqual(test4x4_xyz, m2_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yzx, m2_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zxy, m2_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_xzy, m2_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yxz, m2_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zyx, m2_zyx, (Fp)(0.0001f));

            TestUtils.AreEqual(test4x4_zxy, m3, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_xyz, m3_xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yzx, m3_yzx, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zxy, m3_zxy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_xzy, m3_xzy, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_yxz, m3_yxz, (Fp)(0.0001f));
            TestUtils.AreEqual(test4x4_zyx, m3_zyx, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp2x2_scale()
        {
            Fp2x2 m = Fp2x2((Fp)(1.0f), (Fp)(2.0f),
                (Fp)(3.0f), (Fp)(4.0f));

            Fp2x2 r0 = Fp2x2((Fp)(2.0f), (Fp)(4.0f),
                (Fp)(6.0f), (Fp)(8.0f));

            Fp2x2 r1 = Fp2x2((Fp)(2.0f), (Fp)(4.0f),
                (Fp)(9.0f), (Fp)(12.0f));

            Fp2x2 a = mul(Fp2x2.Scale((Fp)(2.0f)), m);
            Fp2x2 b = mul(Fp2x2.Scale((Fp)(2.0f), (Fp)(3.0f)), m);
            Fp2x2 c = mul(Fp2x2.Scale((Fp)(2.0f), (Fp)(3.0f)), m);

            TestUtils.AreEqual(r0, a);
            TestUtils.AreEqual(r1, b);
            TestUtils.AreEqual(r1, c);
        }

        [TestCompiler]
        public static void Fp3x3_scale()
        {
            Fp3x3 m = Fp3x3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f),
                (Fp)(4.0f), (Fp)(5.0f), (Fp)(6.0f),
                (Fp)(7.0f), (Fp)(8.0f), (Fp)(9.0f));


            Fp3x3 r0 = Fp3x3((Fp)(2.0f), (Fp)(4.0f), (Fp)(6.0f),
                (Fp)(8.0f), (Fp)(10.0f), (Fp)(12.0f),
                (Fp)(14.0f), (Fp)(16.0f), (Fp)(18.0f));

            Fp3x3 r1 = Fp3x3((Fp)(2.0f), (Fp)(4.0f), (Fp)(6.0f),
                (Fp)(12.0f), (Fp)(15.0f), (Fp)(18.0f),
                (Fp)(28.0f), (Fp)(32.0f), (Fp)(36.0f));


            Fp3x3 a = mul(Fp3x3.Scale((Fp)(2.0f)), m);
            Fp3x3 b = mul(Fp3x3.Scale((Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f)), m);
            Fp3x3 c = mul(Fp3x3.Scale((Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f)), m);

            TestUtils.AreEqual(r0, a);
            TestUtils.AreEqual(r1, b);
            TestUtils.AreEqual(r1, c);
        }

        [TestCompiler]
        public static void Fp4x4_scale()
        {
            Fp4x4 m = Fp4x4((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f),
                (Fp)(5.0f), (Fp)(6.0f), (Fp)(7.0f), (Fp)(8.0f),
                (Fp)(9.0f), (Fp)(10.0f), (Fp)(11.0f), (Fp)(12.0f),
                (Fp)(13.0f), (Fp)(14.0f), (Fp)(15.0f), (Fp)(16.0f));

            Fp4x4 r0 = Fp4x4((Fp)(2.0f), (Fp)(4.0f), (Fp)(6.0f), (Fp)(8.0f),
                (Fp)(10.0f), (Fp)(12.0f), (Fp)(14.0f), (Fp)(16.0f),
                (Fp)(18.0f), (Fp)(20.0f), (Fp)(22.0f), (Fp)(24.0f),
                (Fp)(13.0f), (Fp)(14.0f), (Fp)(15.0f), (Fp)(16.0f));

            Fp4x4 r1 = Fp4x4((Fp)(2.0f), (Fp)(4.0f), (Fp)(6.0f), (Fp)(8.0f),
                (Fp)(15.0f), (Fp)(18.0f), (Fp)(21.0f), (Fp)(24.0f),
                (Fp)(36.0f), (Fp)(40.0f), (Fp)(44.0f), (Fp)(48.0f),
                (Fp)(13.0f), (Fp)(14.0f), (Fp)(15.0f), (Fp)(16.0f));

            Fp4x4 a = mul(Fp4x4.Scale((Fp)(2.0f)), m);
            Fp4x4 b = mul(Fp4x4.Scale((Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f)), m);
            Fp4x4 c = mul(Fp4x4.Scale((Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f)), m);

            TestUtils.AreEqual(r0, a);
            TestUtils.AreEqual(r1, b);
            TestUtils.AreEqual(r1, c);
        }

        [TestCompiler]
        public static void Fp2x2_matrix_mul()
        {
            // http://www.wolframalpha.com/input/?i=%5B%5B1,2%5D,%5B3,4%5D%5D*%5B%5B21,22%5D,%5B23,24%5D%5D
            Fp2x2 a = Fp2x2((Fp)(1.0f), (Fp)(2.0f),
                (Fp)(3.0f), (Fp)(4.0f));

            Fp2x2 b = Fp2x2((Fp)(21.0f), (Fp)(22.0f),
                (Fp)(23.0f), (Fp)(24.0f));

            Fp2x2 c = mul(a, b);
            TestUtils.AreEqual((Fp)(67.0f), c.c0.x);
            TestUtils.AreEqual((Fp)(70.0f), c.c1.x);

            TestUtils.AreEqual((Fp)(155.0f), c.c0.y);
            TestUtils.AreEqual((Fp)(162.0f), c.c1.y);
        }

        [TestCompiler]
        public static void Fp3x3_matrix_mul()
        {
            // http://www.wolframalpha.com/input/?i=%5B%5B1,2,3%5D,%5B4,5,6%5D,%5B7,8,9%5D%5D*%5B%5B21,22,23%5D,%5B24,25,26%5D,%5B27,28,29%5D%5D
            Fp3x3 a = Fp3x3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f),
                (Fp)(4.0f), (Fp)(5.0f), (Fp)(6.0f),
                (Fp)(7.0f), (Fp)(8.0f), (Fp)(9.0f));

            Fp3x3 b = Fp3x3((Fp)(21.0f), (Fp)(22.0f), (Fp)(23.0f),
                (Fp)(24.0f), (Fp)(25.0f), (Fp)(26.0f),
                (Fp)(27.0f), (Fp)(28.0f), (Fp)(29.0f));

            Fp3x3 c = mul(a, b);
            TestUtils.AreEqual((Fp)(150.0f), c.c0.x);
            TestUtils.AreEqual((Fp)(156.0f), c.c1.x);
            TestUtils.AreEqual((Fp)(162.0f), c.c2.x);

            TestUtils.AreEqual((Fp)(366.0f), c.c0.y);
            TestUtils.AreEqual((Fp)(381.0f), c.c1.y);
            TestUtils.AreEqual((Fp)(396.0f), c.c2.y);

            TestUtils.AreEqual((Fp)(582.0f), c.c0.z);
            TestUtils.AreEqual((Fp)(606.0f), c.c1.z);
            TestUtils.AreEqual((Fp)(630.0f), c.c2.z);
        }

        [TestCompiler]
        public static void Fp4x4_matrix_mul()
        {
            // https://fogbugz.unity3d.com/f/cases/1041176/
            // http://www.wolframalpha.com/input/?i=%5B%5B1,2,3,4%5D,%5B5,6,7,8%5D,%5B9,10,11,12%5D,%5B13,14,15,16%5D%5D*%5B%5B21,22,23,24%5D,%5B25,26,27,28%5D,%5B29,30,31,32%5D,%5B33,34,35,36%5D%5D
            Fp4x4 a = Fp4x4((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f),
                (Fp)(5.0f), (Fp)(6.0f), (Fp)(7.0f), (Fp)(8.0f),
                (Fp)(9.0f), (Fp)(10.0f), (Fp)(11.0f), (Fp)(12.0f),
                (Fp)(13.0f), (Fp)(14.0f), (Fp)(15.0f), (Fp)(16.0f));

            Fp4x4 b = Fp4x4((Fp)(21.0f), (Fp)(22.0f), (Fp)(23.0f), (Fp)(24.0f),
                (Fp)(25.0f), (Fp)(26.0f), (Fp)(27.0f), (Fp)(28.0f),
                (Fp)(29.0f), (Fp)(30.0f), (Fp)(31.0f), (Fp)(32.0f),
                (Fp)(33.0f), (Fp)(34.0f), (Fp)(35.0f), (Fp)(36.0f));

            Fp4x4 c = mul(a, b);
            TestUtils.AreEqual((Fp)(290.0f), c.c0.x);
            TestUtils.AreEqual((Fp)(300.0f), c.c1.x);
            TestUtils.AreEqual((Fp)(310.0f), c.c2.x);
            TestUtils.AreEqual((Fp)(320.0f), c.c3.x);

            TestUtils.AreEqual((Fp)(722.0f), c.c0.y);
            TestUtils.AreEqual((Fp)(748.0f), c.c1.y);
            TestUtils.AreEqual((Fp)(774.0f), c.c2.y);
            TestUtils.AreEqual((Fp)(800.0f), c.c3.y);

            TestUtils.AreEqual((Fp)(1154.0f), c.c0.z);
            TestUtils.AreEqual((Fp)(1196.0f), c.c1.z);
            TestUtils.AreEqual((Fp)(1238.0f), c.c2.z);
            TestUtils.AreEqual((Fp)(1280.0f), c.c3.z);

            TestUtils.AreEqual((Fp)(1586.0f), c.c0.w);
            TestUtils.AreEqual((Fp)(1644.0f), c.c1.w);
            TestUtils.AreEqual((Fp)(1702.0f), c.c2.w);
            TestUtils.AreEqual((Fp)(1760.0f), c.c3.w);
        }

        [TestCompiler]
        public static void Fp4x4_matrix_mul_limitation()
        {
            Fp4x4 a = new Fp4x4(new Fp4(-1, 0, 0, 0),
                new Fp4(0, (Fp)511L, (Fp)(-4294967294L), 0),
                new Fp4(0, (Fp)(-4294967294L), (Fp)(-512L), 0),
                new Fp4((Fp)(-1060858112L), (Fp)(-20435454107L), (Fp)1374387835L, (Fp)4294967295L));
            Fp4x4 b = new Fp4x4(new Fp4((Fp)(-12884904960L), 0, 0, 0),
                new Fp4(0, (Fp)(-1536L), (Fp)(-12884903936L), 0),
                new Fp4(0, (Fp)(-12884903936L), (Fp)(-1536L), 0),
                new Fp4(new Fp(-1060858112L), new Fp(1374390272L), new Fp(-20435453952L), 1));
            Fp4x4 result = mul(a, b);

            TestUtils.AreEqual(isnan(a.c0), false);
            TestUtils.AreEqual(isnan(a.c1), false);
            TestUtils.AreEqual(isnan(a.c2), false);
            TestUtils.AreEqual(isnan(a.c3), false);

            Fp4 temp = new Fp4(new Fp(-75292672), new Fp(429496704), new Fp(-6108160), 1);
            Fp4x4 c = new Fp4x4(new Fp4(new Fp(4294969600), 0, 0, 0),
                new Fp4(0, new Fp(4294968490), new Fp(1022), 0),
                new Fp4(0, new Fp(1022), new Fp(4294968490), 0),
                new Fp4(new Fp(-271), new Fp(-1362), new Fp(-556), 1));
            Fp3 xyz = mul(c, temp).xyz;
            TestUtils.AreEqual(isnan(xyz), false);

            Fp4x4 d = new Fp4x4(new Fp4(-1, 0, 0, 0), new Fp4(0, new Fp(511), 0, 0),
                new Fp4(0, new Fp(-42949667294), new Fp(-512), 0),
                new Fp4(new Fp(-8461087744), new Fp(-3046), new Fp(12657264634), new Fp(4294967295)));
            Fp4x4 e = new Fp4x4(new Fp4(0, new Fp(-12884904960), 0, 0), new Fp4(0, new Fp(-1536), new Fp(-12884903936), 0),
                new Fp4(0, new Fp(-12884903936), new Fp(-1536), 0),
                new Fp4(new Fp(-8461087744), new Fp(12657264640), new Fp(-1536), 1));
            Fp4x4 rde = IgnoreTooSmallNumber(mul(d, e));
            TestUtils.AreEqual(any(isinf(rde.c0)), false);
            TestUtils.AreEqual(any(isinf(rde.c1)), false);
            TestUtils.AreEqual(any(isinf(rde.c2)), false);
            TestUtils.AreEqual(any(isinf(rde.c3)), false);

            Fp4x4 f = Fp4x4(new Fp4(-1, 0, 0, 0),
                new Fp4(0, new Fp(511), new Fp(-4294967294), 0),
                new Fp4(0, new Fp(-4294967294), new Fp(-512), 0),
                new Fp4(new Fp(-8461087744), new Fp(-3046), new Fp(12657264634), new Fp(4294967295)));

            Fp4x4 j = Fp4x4(new Fp4(new Fp(-12884904960), 0, 0, 0),
                new Fp4(0, new Fp(-1536), new Fp(-12884903936), 0),
                new Fp4(0, new Fp(-12884903936), new Fp(-1536), 0),
                new Fp4(new Fp(-8461087744), new Fp(12657264640), new Fp(-1536), 1));
            Fp4x4 fj = mul(f, j);
            TestUtils.AreEqual(fj.c0.x, 3, Fp.Epsilon);
            TestUtils.AreEqual(fj.c1.y, 3, Fp.Epsilon);
            TestUtils.AreEqual(fj.c2.z, 3, Fp.Epsilon);
            TestUtils.AreEqual(fj.c1.z, (Fp)8.9e-7f, Fp.Epsilon); // float 精度结果 8.9e-7f
            TestUtils.AreEqual(fj.c2.y, (Fp)2.3e-10f, Fp.Epsilon); // float 精度结果 5.3e-7f
            TestUtils.AreEqual(fj.c3.z, -Fp.Inf, Fp.Epsilon); // float 精度结果 2.3e-7f
            TestUtils.AreEqual(fj.c3.w, 1, Fp.Epsilon);
        }

        [TestCompiler]
        public static void Fp2x2_transpose()
        {
            Fp2x2 a = Fp2x2((Fp)(1.0f), (Fp)(2.0f),
                (Fp)(3.0f), (Fp)(4.0f));

            Fp2x2 b = transpose(a);

            TestUtils.AreEqual((Fp)(1.0f), b.c0.x);
            TestUtils.AreEqual((Fp)(3.0f), b.c1.x);
            TestUtils.AreEqual((Fp)(2.0f), b.c0.y);
            TestUtils.AreEqual((Fp)(4.0f), b.c1.y);
        }

        [TestCompiler]
        public static void Fp3x3_transpose()
        {
            Fp3x3 a = Fp3x3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f),
                (Fp)(4.0f), (Fp)(5.0f), (Fp)(6.0f),
                (Fp)(7.0f), (Fp)(8.0f), (Fp)(9.0f));

            Fp3x3 b = transpose(a);

            TestUtils.AreEqual((Fp)(1.0f), b.c0.x);
            TestUtils.AreEqual((Fp)(4.0f), b.c1.x);
            TestUtils.AreEqual((Fp)(7.0f), b.c2.x);
            TestUtils.AreEqual((Fp)(2.0f), b.c0.y);
            TestUtils.AreEqual((Fp)(5.0f), b.c1.y);
            TestUtils.AreEqual((Fp)(8.0f), b.c2.y);
            TestUtils.AreEqual((Fp)(3.0f), b.c0.z);
            TestUtils.AreEqual((Fp)(6.0f), b.c1.z);
            TestUtils.AreEqual((Fp)(9.0f), b.c2.z);
        }

        [TestCompiler]
        public static void Fp4x4_transpose()
        {
            Fp4x4 a = Fp4x4((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f), (Fp)(4.0f),
                (Fp)(5.0f), (Fp)(6.0f), (Fp)(7.0f), (Fp)(8.0f),
                (Fp)(9.0f), (Fp)(10.0f), (Fp)(11.0f), (Fp)(12.0f),
                (Fp)(13.0f), (Fp)(14.0f), (Fp)(15.0f), (Fp)(16.0f));

            Fp4x4 b = transpose(a);

            TestUtils.AreEqual((Fp)(1.0f), b.c0.x);
            TestUtils.AreEqual((Fp)(5.0f), b.c1.x);
            TestUtils.AreEqual((Fp)(9.0f), b.c2.x);
            TestUtils.AreEqual((Fp)(13.0f), b.c3.x);
            TestUtils.AreEqual((Fp)(2.0f), b.c0.y);
            TestUtils.AreEqual((Fp)(6.0f), b.c1.y);
            TestUtils.AreEqual((Fp)(10.0f), b.c2.y);
            TestUtils.AreEqual((Fp)(14.0f), b.c3.y);
            TestUtils.AreEqual((Fp)(3.0f), b.c0.z);
            TestUtils.AreEqual((Fp)(7.0f), b.c1.z);
            TestUtils.AreEqual((Fp)(11.0f), b.c2.z);
            TestUtils.AreEqual((Fp)(15.0f), b.c3.z);
            TestUtils.AreEqual((Fp)(4.0f), b.c0.w);
            TestUtils.AreEqual((Fp)(8.0f), b.c1.w);
            TestUtils.AreEqual((Fp)(12.0f), b.c2.w);
            TestUtils.AreEqual((Fp)(16.0f), b.c3.w);
        }

        [TestCompiler]
        public static void Fp2x2_inverse()
        {
            Fp2x2 a = Fp2x2((Fp)(0.542968f), (Fp)(0.867379f),
                (Fp)(-0.270153f), (Fp)(-0.912324f));

            Fp2x2 invA = Fp2x2((Fp)(3.49499f), (Fp)(3.32281f),
                (Fp)(-1.03492f), (Fp)(-2.08004f));

            Fp2x2 r = inverse(a);

            Fp epsilon = (Fp)(0.0001f);
            TestUtils.AreEqual(r.c0.x, invA.c0.x, epsilon);
            TestUtils.AreEqual(r.c1.x, invA.c1.x, epsilon);

            TestUtils.AreEqual(r.c0.y, invA.c0.y, epsilon);
            TestUtils.AreEqual(r.c1.y, invA.c1.y, epsilon);
        }

        [TestCompiler]
        public static void Fp3x3_inverse()
        {
            Fp3x3 a = Fp3x3((Fp)(0.542968f), (Fp)(0.867379f), (Fp)(0.526616f),
                (Fp)(-0.270153f), (Fp)(-0.912324f), (Fp)(0.148933f),
                (Fp)(0.816727f), (Fp)(0.905933f), (Fp)(0.902392f));

            Fp3x3 invA = Fp3x3((Fp)(-15.91790f), (Fp)(-5.077350f), (Fp)(10.1273f),
                (Fp)(6.07051f), (Fp)(0.994556f), (Fp)(-3.70676f),
                (Fp)(8.31247f), (Fp)(3.596890f), (Fp)(-4.33645f));

            Fp3x3 r = inverse(a);

            Fp epsilon = (Fp)(0.0001f);
            TestUtils.AreEqual(r.c0.x, invA.c0.x, epsilon);
            TestUtils.AreEqual(r.c1.x, invA.c1.x, epsilon);
            TestUtils.AreEqual(r.c2.x, invA.c2.x, epsilon);

            TestUtils.AreEqual(r.c0.y, invA.c0.y, epsilon);
            TestUtils.AreEqual(r.c1.y, invA.c1.y, epsilon);
            TestUtils.AreEqual(r.c2.y, invA.c2.y, epsilon);

            TestUtils.AreEqual(r.c0.z, invA.c0.z, epsilon);
            TestUtils.AreEqual(r.c1.z, invA.c1.z, epsilon);
            TestUtils.AreEqual(r.c2.z, invA.c2.z, epsilon);
        }

        [TestCompiler]
        public static void Fp4x4_inverse()
        {
            Fp4x4 a = Fp4x4((Fp)(0.542968f), (Fp)(0.867379f), (Fp)(0.526616f), (Fp)(-0.943083f),
                (Fp)(-0.270153f), (Fp)(-0.912324f), (Fp)(0.148933f), (Fp)(0.299995f),
                (Fp)(0.816727f), (Fp)(0.905933f), (Fp)(0.902392f), (Fp)(-0.060931f),
                (Fp)(-0.254780f), (Fp)(0.604543f), (Fp)(0.563340f), (Fp)(-0.383911f));

            Fp4x4 invA = Fp4x4((Fp)(0.548951f), (Fp)(0.126367f), (Fp)(0.487260f), (Fp)(-1.327100f),
                (Fp)(-0.582901f), (Fp)(-1.108000f), (Fp)(0.188292f), (Fp)(0.536211f),
                (Fp)(0.001968f), (Fp)(0.970678f), (Fp)(0.528701f), (Fp)(0.669759f),
                (Fp)(-1.279310f), (Fp)(-0.404277f), (Fp)(0.748937f), (Fp)(0.103102f));

            Fp4x4 r = inverse(a);

            Fp epsilon = (Fp)(0.0001f);
            TestUtils.AreEqual(r.c0.x, invA.c0.x, epsilon);
            TestUtils.AreEqual(r.c1.x, invA.c1.x, epsilon);
            TestUtils.AreEqual(r.c2.x, invA.c2.x, epsilon);
            TestUtils.AreEqual(r.c3.x, invA.c3.x, epsilon);

            TestUtils.AreEqual(r.c0.y, invA.c0.y, epsilon);
            TestUtils.AreEqual(r.c1.y, invA.c1.y, epsilon);
            TestUtils.AreEqual(r.c2.y, invA.c2.y, epsilon);
            TestUtils.AreEqual(r.c3.y, invA.c3.y, epsilon);

            TestUtils.AreEqual(r.c0.z, invA.c0.z, epsilon);
            TestUtils.AreEqual(r.c1.z, invA.c1.z, epsilon);
            TestUtils.AreEqual(r.c2.z, invA.c2.z, epsilon);
            TestUtils.AreEqual(r.c3.z, invA.c3.z, epsilon);

            TestUtils.AreEqual(r.c0.w, invA.c0.w, epsilon);
            TestUtils.AreEqual(r.c1.w, invA.c1.w, epsilon);
            TestUtils.AreEqual(r.c2.w, invA.c2.w, epsilon);
            TestUtils.AreEqual(r.c3.w, invA.c3.w, epsilon);

            if (Fp4x4.Inverse(a, out Fp4x4 r1))
            {
                TestUtils.AreEqual(r1.c0.x, invA.c0.x, epsilon);
                TestUtils.AreEqual(r1.c1.x, invA.c1.x, epsilon);
                TestUtils.AreEqual(r1.c2.x, invA.c2.x, epsilon);
                TestUtils.AreEqual(r1.c3.x, invA.c3.x, epsilon);

                TestUtils.AreEqual(r1.c0.y, invA.c0.y, epsilon);
                TestUtils.AreEqual(r1.c1.y, invA.c1.y, epsilon);
                TestUtils.AreEqual(r1.c2.y, invA.c2.y, epsilon);
                TestUtils.AreEqual(r1.c3.y, invA.c3.y, epsilon);

                TestUtils.AreEqual(r1.c0.z, invA.c0.z, epsilon);
                TestUtils.AreEqual(r1.c1.z, invA.c1.z, epsilon);
                TestUtils.AreEqual(r1.c2.z, invA.c2.z, epsilon);
                TestUtils.AreEqual(r1.c3.z, invA.c3.z, epsilon);

                TestUtils.AreEqual(r1.c0.w, invA.c0.w, epsilon);
                TestUtils.AreEqual(r1.c1.w, invA.c1.w, epsilon);
                TestUtils.AreEqual(r1.c2.w, invA.c2.w, epsilon);
                TestUtils.AreEqual(r1.c3.w, invA.c3.w, epsilon);
            }
        }

        [TestCompiler]
        public static void Fp4x4_inverse_limitation()
        {
            Fp4x4 a = new Fp4x4(new Fp4(-1, 0, 0, 0),
                new Fp4(0, (Fp)512L, (Fp)(-4294967298L), 0),
                new Fp4(0, (Fp)(-4294967298L), (Fp)(-512L), 0),
                new Fp4((Fp)(-1060858112L), (Fp)(1374390272L), (Fp)(-20435453952L), 1));

            Fp4x4 r = inverse(a);
            Fp4x4.Inverse(a, out Fp4x4 r1);
            Fp epsilon = 0;
            // ** NOTE:忽略极小值后可以计算出一个大致正确的逆矩阵
            // TestUtils.AreEqual(r.c0, Fp4(-Fp.Inf), epsilon);
            // TestUtils.AreEqual(r.c1, Fp4(-Fp.Inf), epsilon);
            // TestUtils.AreEqual(r.c2, Fp4(-Fp.Inf), epsilon);
            // TestUtils.AreEqual(r.c3, Fp4(-Fp.Inf), epsilon);

            TestUtils.AreEqual(r1.c0, Fp4(Fp.NaN), epsilon);
            TestUtils.AreEqual(r1.c1, Fp4(Fp.NaN), epsilon);
            TestUtils.AreEqual(r1.c2, Fp4(Fp.NaN), epsilon);
            TestUtils.AreEqual(r1.c3, Fp4(Fp.NaN), epsilon);

            Fp4x4 b = new Fp4x4(new Fp4(-1, 0, 0, 0), new Fp4(0, new Fp(512), new Fp(-4294967298), 0),
                new Fp4(0, new Fp(-4294967298), new Fp(-512), 0),
                new Fp4(new Fp(5033702400), new Fp(12657264640), new Fp(-1536), 1));
            Fp4x4 rb = inverse(b);
            TestUtils.AreEqual(any(isinf(rb.c0)), false);
            TestUtils.AreEqual(any(isinf(rb.c1)), false);
            TestUtils.AreEqual(any(isinf(rb.c2)), false);
            TestUtils.AreEqual(any(isinf(rb.c3)), false);
        }

        [TestCompiler]
        public static void Fp3x4_fastinverse()
        {
            Fp4x4 a = test4x4_xyz;
            a.c3 = Fp4(1, 2, 3, 1);

            Fp3x4 b = Fp3x4(a.c0.xyz, a.c1.xyz, a.c2.xyz, a.c3.xyz);

            Fp4x4 invA = inverse(a);
            Fp3x4 fastInvB = fastinverse(b);

            TestUtils.AreEqual(invA.c0.xyz, fastInvB.c0.xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(invA.c1.xyz, fastInvB.c1.xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(invA.c2.xyz, fastInvB.c2.xyz, (Fp)(0.0001f));
            TestUtils.AreEqual(invA.c3.xyz, fastInvB.c3.xyz, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp4x4_fastinverse()
        {
            Fp4x4 a = test4x4_xyz;
            a.c3 = Fp4(1, 2, 3, 1);

            Fp4x4 invA = inverse(a);
            Fp4x4 fastInvA = fastinverse(a);

            TestUtils.AreEqual(invA, fastInvA, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp2x2_determinant()
        {
            Fp2x2 a = Fp2x2((Fp)(0.542968f), (Fp)(0.867379f),
                (Fp)(-0.270153f), (Fp)(-0.912324f));

            Fp det = determinant(a);
            TestUtils.AreEqual((Fp)(-0.2610378f), det, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp3x3_determinant()
        {
            Fp3x3 a = Fp3x3((Fp)(0.542968f), (Fp)(0.867379f), (Fp)(0.526616f),
                (Fp)(-0.270153f), (Fp)(-0.912324f), (Fp)(0.148933f),
                (Fp)(0.816727f), (Fp)(0.905933f), (Fp)(0.902392f));

            Fp det = determinant(a);
            TestUtils.AreEqual((Fp)(0.06019618f), det, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp4x4_determinant()
        {
            Fp4x4 a = Fp4x4((Fp)(0.542968f), (Fp)(0.867379f), (Fp)(0.526616f), (Fp)(-0.943083f),
                (Fp)(-0.270153f), (Fp)(-0.912324f), (Fp)(0.148933f), (Fp)(0.299995f),
                (Fp)(0.816727f), (Fp)(0.905933f), (Fp)(0.902392f), (Fp)(-0.060931f),
                (Fp)(-0.254780f), (Fp)(0.604543f), (Fp)(0.563340f), (Fp)(-0.383911f));

            Fp det = determinant(a);
            TestUtils.AreEqual((Fp)(0.5838502f), det, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void Fp3x3_look_rotation()
        {
            Fp3 forward0 = normalize(Fp3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f)));
            Fp3 up0 = Fp3((Fp)(0.0f), (Fp)(1.0f), (Fp)(0.0f));
            Fp3x3 m0 = Fp3x3.LookRotation(forward0, up0);
            TestUtils.AreEqual(Fp3x3((Fp)(0.948683f), (Fp)(-0.169031f), (Fp)(0.267261f),
                (Fp)(0.000000f), (Fp)(0.845154f), (Fp)(0.534523f),
                (Fp)(-0.316228f), (Fp)(-0.507093f), (Fp)(0.801784f)), m0, (Fp)(0.001f));
            TestUtils.AreEqual(Fp3x3(QuaternionFp.LookRotation(forward0, up0)), m0, (Fp)(0.001f));

            Fp3 forward1 = normalize(Fp3((Fp)(-3.2f), (Fp)(2.3f), (Fp)(-1.3f)));
            Fp3 up1 = normalize(Fp3((Fp)(1.0f), (Fp)(-3.2f), (Fp)(-1.5f)));
            Fp3x3 m1 = Fp3x3.LookRotation(forward1, up1);
            TestUtils.AreEqual(Fp3x3((Fp)(0.605102f), (Fp)(-0.197976f), (Fp)(-0.771140f),
                (Fp)(0.485036f), (Fp)(-0.676417f), (Fp)(0.554257f),
                (Fp)(-0.631342f), (Fp)(-0.709413f), (Fp)(-0.313276f)), m1, (Fp)(0.001f));
            TestUtils.AreEqual(Fp3x3(QuaternionFp.LookRotation(forward1, up1)), m1, (Fp)(0.001f));

            Fp3 forward2 = normalize(Fp3((Fp)(-2.6f), (Fp)(-5.2f), (Fp)(-1.1f)));
            Fp3 up2 = normalize(Fp3((Fp)(-4.2f), (Fp)(-1.2f), (Fp)(-4.5f)));
            Fp3x3 m2 = Fp3x3.LookRotation(forward2, up2);
            TestUtils.AreEqual(Fp3x3((Fp)(-0.740918f), (Fp)(-0.507890f), (Fp)(-0.439418f),
                (Fp)(0.237577f), (Fp)(0.413771f), (Fp)(-0.878835f),
                (Fp)(0.628170f), (Fp)(-0.755540f), (Fp)(-0.185907f)), m2, (Fp)(0.001f));
            TestUtils.AreEqual(Fp3x3(QuaternionFp.LookRotation(forward2, up2)), m2, (Fp)(0.001f));

            Fp3 forward3 = normalize(Fp3((Fp)(1.3f), (Fp)(2.1f), (Fp)(3.4f)));
            Fp3 up3 = normalize(Fp3((Fp)(0.2f), (Fp)(-1.0f), (Fp)(0.3f)));
            Fp3x3 m3 = Fp3x3.LookRotation(forward3, up3);
            TestUtils.AreEqual(Fp3x3((Fp)(-0.917727f), (Fp)(0.249162f), (Fp)(0.309349f),
                (Fp)(-0.066040f), (Fp)(-0.863668f), (Fp)(0.499717f),
                (Fp)(0.391685f), (Fp)(0.438174f), (Fp)(0.809065f)), m3, (Fp)(0.001f));
            TestUtils.AreEqual(Fp3x3(QuaternionFp.LookRotation(forward3, up3)), m3, (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp3x3_look_rotation_safe()
        {
            Fp3 forward0 = Fp3((Fp)(-3.2f), (Fp)(2.3f), (Fp)(-1.3f)) * Fp.OneEMinus4;
            Fp3 up0 = Fp3((Fp)(1.0f), (Fp)(-3.2f), (Fp)(-1.5f)) * Fp.OneEMinus4;
            Fp3x3 m0 = Fp3x3.LookRotationSafe(forward0, up0);
            TestUtils.AreEqual(Fp3x3((Fp)(0.605102f), (Fp)(-0.197976f), (Fp)(-0.771140f),
                (Fp)(0.485036f), (Fp)(-0.676417f), (Fp)(0.554257f),
                (Fp)(-0.631342f), (Fp)(-0.709413f), (Fp)(-0.313276f)), m0, (Fp)(0.001f));

            Fp3 forward1 = Fp3((Fp)(-3.2f), (Fp)(2.3f), (Fp)(-1.3f)) * Fp.OneEMinus8;
            Fp3 up1 = Fp3((Fp)(1.0f), (Fp)(-3.2f), (Fp)(-1.5f));
            Fp3x3 m1 = Fp3x3.LookRotationSafe(forward1, up1);
            TestUtils.AreEqual(Fp3x3.identity, m1, (Fp)(0.001f));
        }


        [TestCompiler]
        public static void Fp4x4_lookat()
        {
            Fp4x4 m = Fp4x4.LookAt(Fp3((Fp)(0.3f), (Fp)(-0.5f), (Fp)(3.0f)), Fp3((Fp)(3.2f), (Fp)(-3.1f), (Fp)(0.2f)), normalize(Fp3((Fp)(0.3f), (Fp)(1.0f), (Fp)(-3.0f))));
            Fp4x4 r = Fp4x4(
                (Fp)(-0.77374f), (Fp)(-0.18930f), (Fp)(0.60456f), (Fp)(0.30000f),
                (Fp)(-0.57373f), (Fp)(0.61404f), (Fp)(-0.54202f), (Fp)(-0.50000f),
                (Fp)(-0.26862f), (Fp)(-0.76624f), (Fp)(-0.58371f), (Fp)(3.00000f),
                (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(1.00000f)
            );
            TestUtils.AreEqual(r, m, (Fp)(0.001f));
        }


        [TestCompiler]
        public static void Fp4x4_ortho()
        {
            Fp4x4 m = Fp4x4.Ortho((Fp)(2.0f), (Fp)(3.0f), (Fp)(-3.0f), (Fp)(7.0f));
            Fp4x4 r = Fp4x4(
                (Fp)(1.00000f), (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(0.00000f),
                (Fp)(0.00000f), (Fp)(0.66667f), (Fp)(0.00000f), (Fp)(0.00000f),
                (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(-0.20000f), (Fp)(-0.40000f),
                (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(1.00000f)
            );
            TestUtils.AreEqual(r, m, (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp4x4_orthoOffCenter()
        {
            Fp4x4 m = Fp4x4.OrthoOffCenter((Fp)(-2.0f), (Fp)(1.0f), (Fp)(-3.0f), (Fp)(-1.0f), (Fp)(-3.0f), (Fp)(7.0f));
            Fp4x4 r = Fp4x4(
                (Fp)(0.66667f), (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(0.33333f),
                (Fp)(0.00000f), (Fp)(1.00000f), (Fp)(0.00000f), (Fp)(2.00000f),
                (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(-0.20000f), (Fp)(-0.40000f),
                (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(1.00000f)
            );
            TestUtils.AreEqual(r, m, (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp4x4_perspective()
        {
            Fp fovy = (Fp)(1.6f);
            Fp aspect = (Fp)(1.3333f);
            Fp near = (Fp)(0.1f);
            Fp far = (Fp)(100.0f);

            Fp height = tan(fovy * (Fp)(0.5f)) * near;
            Fp width = height * (Fp)(1.3333f);

            Fp4x4 m = Fp4x4.PerspectiveFov(fovy, aspect, near, far);
            Fp4x4 r = Fp4x4(
                (Fp)(0.72843f), (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(0.00000f),
                (Fp)(0.00000f), (Fp)(0.97121f), (Fp)(0.00000f), (Fp)(0.00000f),
                (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(-1.00200f), (Fp)(-0.20020f),
                (Fp)(0.00000f), (Fp)(0.00000f), (Fp)(-1.00000f), (Fp)(0.00000f)
            );
            TestUtils.AreEqual(r, m, (Fp)(0.001f));

            Fp4 p0 = mul(m, Fp4(-width, -height, -near, (Fp)(1.0f)));
            Fp4 pp0 = p0 / p0.w;
            TestUtils.AreEqual(Fp3((Fp)(-1.0f), (Fp)(-1.0f), (Fp)(-1.0f)), pp0.xyz, (Fp)(0.001f));

            Fp4 p1 = mul(m, Fp4(width / near * far, height / near * far, -far, (Fp)(1.0f)));
            Fp4 pp1 = p1 / p1.w;
            TestUtils.AreEqual(Fp3((Fp)(1.0f), (Fp)(1.0f), (Fp)(1.0f)), pp1.xyz, (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp4x4_perspectiveOffCenter()
        {
            Fp fovy = (Fp)(1.6f);
            Fp aspect = (Fp)(1.3333f);
            Fp near = (Fp)(0.1f);
            Fp far = (Fp)(100.0f);

            Fp4x4 r0 = Fp4x4.PerspectiveFov(fovy, aspect, near, far);

            Fp height = tan(fovy * (Fp)(0.5f)) * near;
            Fp width = height * (Fp)(1.3333f);

            Fp4x4 m0 = Fp4x4.PerspectiveOffCenter(-width, width, -height, height, (Fp)(0.1f), (Fp)(100.0f));
            TestUtils.AreEqual(r0, m0, (Fp)(0.001f));

            Fp left = (Fp)(-0.3f);
            Fp right = (Fp)(-0.1f);
            Fp bottom = (Fp)(-0.2f);
            Fp top = (Fp)(0.1f);
            Fp4x4 m1 = Fp4x4.PerspectiveOffCenter(left, right, bottom, top, near, far);
            Fp4 p0 = mul(m1, Fp4(left, bottom, -near, (Fp)(1.0f)));
            Fp4 pp0 = p0 / p0.w;
            TestUtils.AreEqual(Fp3((Fp)(-1.0f), (Fp)(-1.0f), (Fp)(-1.0f)), pp0.xyz, (Fp)(0.001f));

            Fp4 p1 = mul(m1, Fp4(right, top, -near, (Fp)(1.0f)));
            Fp4 pp1 = p1 / p1.w;
            TestUtils.AreEqual(Fp3((Fp)(1.0f), (Fp)(1.0f), (Fp)(-1.0f)), pp1.xyz, (Fp)(0.001f));

            Fp4 p2 = mul(m1, Fp4(left * far / near, top * far / near, -far, (Fp)(1.0f)));
            Fp4 pp2 = p2 / p2.w;
            TestUtils.AreEqual(Fp3((Fp)(-1.0f), (Fp)(1.0f), (Fp)(1.0f)), pp2.xyz, (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp4x4_TRS()
        {
            Fp3 scale = Fp3((Fp)(1.2f), (Fp)(-0.4f), (Fp)(2.3f));
            QuaternionFp rotation = TestQuaternion.test_q0;
            Fp3 translation = Fp3((Fp)(12.3f), (Fp)(-4.3f), (Fp)(135.99f));
            Fp4x4 r0 = mul(Fp4x4(QuaternionFp.Identity, translation), mul(Fp4x4(rotation, Fp3.zero), Fp4x4.Scale(scale)));
            Fp4x4 m0 = Fp4x4.TRS(translation, rotation, scale);
            TestUtils.AreEqual(r0, m0, (Fp)(0.001f));
        }

        [TestCompiler]
        public static void Fp3x3_constructor_Fp4x4()
        {
            var f4x4 = new Fp4x4(new Fp4(1, 2, 3, 4), new Fp4(5, 6, 7, 8), new Fp4(9, 10, 11, 12), new Fp4(13, 14, 15, 16));
            var expected = new Fp3x3(new Fp3(1, 2, 3), new Fp3(5, 6, 7), new Fp3(9, 10, 11));

            TestUtils.AreEqual(expected, new Fp3x3(f4x4));
        }

        [TestCompiler]
        public static void Fp3x3_explicit_cast_Fp4x4()
        {
            var f4x4 = new Fp4x4(new Fp4(1, 2, 3, 4), new Fp4(5, 6, 7, 8), new Fp4(9, 10, 11, 12), new Fp4(13, 14, 15, 16));
            var expected = new Fp3x3(new Fp3(1, 2, 3), new Fp3(5, 6, 7), new Fp3(9, 10, 11));

            TestUtils.AreEqual(expected, (Fp3x3)f4x4);
        }

        [TestCompiler]
        public static void Fp3x3_from_Fp4x4_without_new()
        {
            var f4x4 = new Fp4x4(new Fp4(1, 2, 3, 4), new Fp4(5, 6, 7, 8), new Fp4(9, 10, 11, 12), new Fp4(13, 14, 15, 16));
            var expected = new Fp3x3(new Fp3(1, 2, 3), new Fp3(5, 6, 7), new Fp3(9, 10, 11));

            TestUtils.AreEqual(expected, Fp3x3(f4x4));
        }
    }
}