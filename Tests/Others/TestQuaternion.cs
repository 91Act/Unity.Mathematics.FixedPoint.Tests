using NUnit.Framework;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.FixedPoint.Tests
{
    [TestFixture]
    class TestQuaternion
    {
        [TestCompiler]
        public static void quaternion_basic_constructors()
        {
            QuaternionFp q = MathFp.QuaternionFp((Fp)1.0f, (Fp)2.0f, (Fp)3.0f, (Fp)4.0f);
            QuaternionFp q2 = MathFp.QuaternionFp(MathFp.Fp4((Fp)1.0f, (Fp)2.0f, (Fp)3.0f, (Fp)4.0f));

            TestUtils.AreEqual((Fp)1.0f, q.value.x);
            TestUtils.AreEqual((Fp)2.0f, q.value.y);
            TestUtils.AreEqual((Fp)3.0f, q.value.z);
            TestUtils.AreEqual((Fp)4.0f, q.value.w);
            TestUtils.AreEqual((Fp)1.0f, q2.value.x);
            TestUtils.AreEqual((Fp)2.0f, q2.value.y);
            TestUtils.AreEqual((Fp)3.0f, q2.value.z);
            TestUtils.AreEqual((Fp)4.0f, q2.value.w);
        }

        [TestCompiler]
        public static void quaternion_construct_from_matrix()
        {
            TestUtils.AreEqual(MathFp.Fp3x3(MathFp.QuaternionFp(TestMatrix.test3x3_xyz)), TestMatrix.test3x3_xyz,
                (Fp)0.0001f);
            TestUtils.AreEqual(MathFp.Fp4x4(MathFp.QuaternionFp(TestMatrix.test4x4_xyz), Fp3.zero),
                TestMatrix.test4x4_xyz, (Fp)0.0001f);

            // Make sure to hit all 4 cases
            Fp3x3 m0 = Fp3x3.AxisAngle(MathFp.normalize(MathFp.Fp3(1, 2, 3)), (Fp)1.0f);
            Fp3x3 m1 = Fp3x3.AxisAngle(MathFp.normalize(MathFp.Fp3(3, 2, 1)), (Fp)3.0f);
            Fp3x3 m2 = Fp3x3.AxisAngle(MathFp.normalize(MathFp.Fp3(1, 3, 2)), (Fp)3.0f);
            Fp3x3 m3 = Fp3x3.AxisAngle(MathFp.normalize(MathFp.Fp3(1, 2, 3)), (Fp)3.0f);
            QuaternionFp q0 = MathFp.QuaternionFp(m0);
            QuaternionFp q1 = MathFp.QuaternionFp(m1);
            QuaternionFp q2 = MathFp.QuaternionFp(m2);
            QuaternionFp q3 = MathFp.QuaternionFp(m3);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.1281319f, (Fp)0.2562638f, (Fp)0.3843956f, (Fp)0.8775827f), q0,
                (Fp)0.0001f);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.7997754f, (Fp)0.5331835f, (Fp)0.2665918f, (Fp)0.0707372f), q1,
                (Fp)0.0001f);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.2665918f, (Fp)0.7997754f, (Fp)0.5331835f, (Fp)0.0707372f), q2,
                (Fp)0.0001f);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.2665918f, (Fp)0.5331835f, (Fp)0.7997754f, (Fp)0.0707372f), q3,
                (Fp)0.0001f);
        }


        [TestCompiler]
        public static void quaternion_construct_from_matrix3x3_torture()
        {
            Random rnd = new Random(0x12345678);
            for (int i = 0; i < 1000; i++)
            {
                Fp3x3 r = MathFp.Fp3x3(rnd.NextQuaternionRotation());
                QuaternionFp q = MathFp.QuaternionFp(r);
                Fp3x3 t = MathFp.Fp3x3(q);
                TestUtils.AreEqual(r, t, (Fp)0.001f);
            }
        }

        [TestCompiler]
        public static void quaternion_construct_from_matrix4x4_torture()
        {
            Random rnd = new Random(0x12345678);
            for (int i = 0; i < 1000; i++)
            {
                Fp4x4 r = MathFp.Fp4x4(rnd.NextQuaternionRotation(), Fp3.zero);
                QuaternionFp q = MathFp.QuaternionFp(r);
                Fp4x4 t = MathFp.Fp4x4(q, Fp3.zero);
                TestUtils.AreEqual(r, t, (Fp)0.001f);
            }
        }

        [TestCompiler]
        public static void quaternion_axis_angle()
        {
            QuaternionFp q =
                QuaternionFp.AxisAngle(MathFp.normalize(MathFp.Fp3((Fp)1.0f, (Fp)2.0f, (Fp)3.0f)), (Fp)10.0f);

            QuaternionFp r = MathFp.QuaternionFp((Fp)(-0.2562833f), (Fp)(-0.5125666f), (Fp)(-0.76885f), (Fp)0.2836622f);
            TestUtils.AreEqual(r, q, (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_axis_angle_consistency()
        {
            TestUtils.AreEqual(QuaternionFp.RotateX((Fp)1.0f), QuaternionFp.AxisAngle(MathFp.Fp3(1, 0, 0), (Fp)1.0f),
                (Fp)0.001f);
            TestUtils.AreEqual(QuaternionFp.RotateY((Fp)1.0f), QuaternionFp.AxisAngle(MathFp.Fp3(0, 1, 0), (Fp)1.0f),
                (Fp)0.001f);
            TestUtils.AreEqual(QuaternionFp.RotateZ((Fp)1.0f), QuaternionFp.AxisAngle(MathFp.Fp3(0, 0, 1), (Fp)1.0f),
                (Fp)0.001f);
        }

        [TestCompiler]
        public static void quaternion_euler()
        {
            Fp3 test_angles = TestMatrix.test_angles;
            QuaternionFp q0 = QuaternionFp.Euler(test_angles);
            QuaternionFp q0_xyz = QuaternionFp.Euler(test_angles, MathFp.RotationOrder.XYZ);
            QuaternionFp q0_xzy = QuaternionFp.Euler(test_angles, MathFp.RotationOrder.XZY);
            QuaternionFp q0_yxz = QuaternionFp.Euler(test_angles, MathFp.RotationOrder.YXZ);
            QuaternionFp q0_yzx = QuaternionFp.Euler(test_angles, MathFp.RotationOrder.YZX);
            QuaternionFp q0_zxy = QuaternionFp.Euler(test_angles, MathFp.RotationOrder.ZXY);
            QuaternionFp q0_zyx = QuaternionFp.Euler(test_angles, MathFp.RotationOrder.ZYX);

            QuaternionFp q1 = QuaternionFp.Euler(test_angles.x, test_angles.y, test_angles.z);
            QuaternionFp q1_xyz =
                QuaternionFp.Euler(test_angles.x, test_angles.y, test_angles.z, MathFp.RotationOrder.XYZ);
            QuaternionFp q1_xzy =
                QuaternionFp.Euler(test_angles.x, test_angles.y, test_angles.z, MathFp.RotationOrder.XZY);
            QuaternionFp q1_yxz =
                QuaternionFp.Euler(test_angles.x, test_angles.y, test_angles.z, MathFp.RotationOrder.YXZ);
            QuaternionFp q1_yzx =
                QuaternionFp.Euler(test_angles.x, test_angles.y, test_angles.z, MathFp.RotationOrder.YZX);
            QuaternionFp q1_zxy =
                QuaternionFp.Euler(test_angles.x, test_angles.y, test_angles.z, MathFp.RotationOrder.ZXY);
            QuaternionFp q1_zyx =
                QuaternionFp.Euler(test_angles.x, test_angles.y, test_angles.z, MathFp.RotationOrder.ZYX);

            Fp epsilon = (Fp)0.0001f;
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.3435619f, (Fp)0.3899215f, (Fp)0.7948176f),
                q0, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.4597331f), (Fp)0.06979711f, (Fp)0.3899215f, (Fp)0.7948176f),
                q0_xyz, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.06979711f, (Fp)0.3899215f, (Fp)0.8630749f),
                q0_xzy, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.4597331f), (Fp)0.06979711f, (Fp)0.1971690f, (Fp)0.8630748f),
                q0_yxz, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.4597331f), (Fp)0.34356190f, (Fp)0.1971690f, (Fp)0.7948176f),
                q0_yzx, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.34356190f, (Fp)0.3899215f, (Fp)0.7948176f),
                q0_zxy, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.34356190f, (Fp)0.1971690f, (Fp)0.8630749f),
                q0_zyx, epsilon);

            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.3435619f, (Fp)0.3899215f, (Fp)0.7948176f),
                q1, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.4597331f), (Fp)0.06979711f, (Fp)0.3899215f, (Fp)0.7948176f),
                q1_xyz, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.06979711f, (Fp)0.3899215f, (Fp)0.8630749f),
                q1_xzy, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.4597331f), (Fp)0.06979711f, (Fp)0.1971690f, (Fp)0.8630748f),
                q1_yxz, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.4597331f), (Fp)0.34356190f, (Fp)0.1971690f, (Fp)0.7948176f),
                q1_yzx, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.34356190f, (Fp)0.3899215f, (Fp)0.7948176f),
                q1_zxy, epsilon);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.3133549f), (Fp)0.34356190f, (Fp)0.1971690f, (Fp)0.8630749f),
                q1_zyx, epsilon);

            Fp3x3 m0 = MathFp.Fp3x3(q0);
            Fp3x3 m0_xyz = MathFp.Fp3x3(q0_xyz);
            Fp3x3 m0_xzy = MathFp.Fp3x3(q0_xzy);
            Fp3x3 m0_yxz = MathFp.Fp3x3(q0_yxz);
            Fp3x3 m0_yzx = MathFp.Fp3x3(q0_yzx);
            Fp3x3 m0_zxy = MathFp.Fp3x3(q0_zxy);
            Fp3x3 m0_zyx = MathFp.Fp3x3(q0_zyx);

            Fp3x3 m1 = MathFp.Fp3x3(q1);
            Fp3x3 m1_xyz = MathFp.Fp3x3(q1_xyz);
            Fp3x3 m1_xzy = MathFp.Fp3x3(q1_xzy);
            Fp3x3 m1_yxz = MathFp.Fp3x3(q1_yxz);
            Fp3x3 m1_yzx = MathFp.Fp3x3(q1_yzx);
            Fp3x3 m1_zxy = MathFp.Fp3x3(q1_zxy);
            Fp3x3 m1_zyx = MathFp.Fp3x3(q1_zyx);

            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m0, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xyz, m0_xyz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yzx, m0_yzx, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m0_zxy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xzy, m0_xzy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yxz, m0_yxz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zyx, m0_zyx, (Fp)0.0001f);

            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m1, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xyz, m1_xyz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yzx, m1_yzx, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m1_zxy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xzy, m1_xzy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yxz, m1_yxz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zyx, m1_zyx, epsilon);
        }

        [TestCompiler]
        public static void quaternion_rotateX()
        {
            Fp angle = (Fp)2.3f;
            QuaternionFp q = QuaternionFp.RotateX(angle);

            QuaternionFp r = MathFp.QuaternionFp((Fp)0.91276394f, (Fp)0.0f, (Fp)0.0f, (Fp)0.40848744f);
            TestUtils.AreEqual(r, q, (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_rotateY()
        {
            Fp angle = (Fp)2.3f;
            QuaternionFp q = QuaternionFp.RotateY(angle);

            QuaternionFp r = MathFp.QuaternionFp((Fp)0.0f, (Fp)0.91276394f, (Fp)0.0f, (Fp)0.40848744f);
            TestUtils.AreEqual(r, q, (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_rotateZ()
        {
            Fp angle = (Fp)2.3f;
            QuaternionFp q = QuaternionFp.RotateZ(angle);

            QuaternionFp r = MathFp.QuaternionFp((Fp)0.0f, (Fp)0.0f, (Fp)0.91276394f, (Fp)0.40848744f);
            TestUtils.AreEqual(r, q, (Fp)0.0001f);
        }

        static internal readonly QuaternionFp test_q0 =
            new QuaternionFp((Fp)0.3270836f, (Fp)0.8449658f, (Fp)(-0.1090279f), (Fp)0.4088545f);

        static internal readonly QuaternionFp test_q1 =
            new QuaternionFp((Fp)(-0.05623216f), (Fp)0.731018f, (Fp)(-0.6747859f), (Fp)(-0.08434824f));

        static internal readonly QuaternionFp test_q2 =
            new QuaternionFp((Fp)(-0.2316205f), (Fp)(-0.6022133f), (Fp)(-0.7411857f), (Fp)(-0.1852964f));

        static internal readonly QuaternionFp test_q3 =
            new QuaternionFp((Fp)0.3619499f, (Fp)0.8352691f, (Fp)(-0.1392115f), (Fp)0.3897922f);

        [TestCompiler]
        public static void quaternion_conjugate()
        {
            QuaternionFp q = MathFp.QuaternionFp((Fp)1.0f, (Fp)(-2.0f), (Fp)3.0f, (Fp)(-4.0f));
            QuaternionFp cq = MathFp.conjugate(q);
            QuaternionFp r = MathFp.QuaternionFp((Fp)(-1.0f), (Fp)2.0f, (Fp)(-3.0f), (Fp)(-4.0f));

            TestUtils.AreEqual(r, cq);
        }

        [TestCompiler]
        public static void quaternion_inverse()
        {
            QuaternionFp q = MathFp.QuaternionFp((Fp)1.0f, (Fp)(-2.0f), (Fp)3.0f, (Fp)(-4.0f));
            QuaternionFp iq = MathFp.inverse(q);
            QuaternionFp qiq = MathFp.mul(iq, q);

            TestUtils.AreEqual(QuaternionFp.Identity, qiq, (Fp)0.00001f);
        }

        [TestCompiler]
        public static void quaternion_dot()
        {
            Fp dot01 = MathFp.dot(test_q0, test_q1);
            Fp dot02 = MathFp.dot(test_q0, test_q2);

            TestUtils.AreEqual((Fp)0.6383769f, dot01, (Fp)0.00001f);
            TestUtils.AreEqual((Fp)(-0.5795583f), dot02, (Fp)0.00001f);
        }

        [TestCompiler]
        public static void quaternion_nlerp()
        {
            QuaternionFp r0 = MathFp.nlerp(test_q0, test_q1, (Fp)0.3f);
            QuaternionFp r1 = MathFp.nlerp(test_q0, test_q1, (Fp)(-4.3f));
            QuaternionFp r2 = MathFp.nlerp(test_q0, test_q1, (Fp)5.1f);

            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.2302977f, (Fp)0.8803911f, (Fp)(-0.3026878f), (Fp)0.2832927f),
                r0, (Fp)0.0001f);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.4724294f, (Fp)0.3192692f, (Fp)0.5557517f, (Fp)0.604994f), r1,
                (Fp)0.0001f);
            TestUtils.AreEqual(
                MathFp.QuaternionFp((Fp)(-0.4054004f), (Fp)0.06570576f, (Fp)(-0.7457358f), (Fp)(-0.5246059f)), r2,
                (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_slerp()
        {
            QuaternionFp r0 = MathFp.slerp(test_q0, test_q1, (Fp)0.3f);
            QuaternionFp r1 = MathFp.slerp(test_q0, test_q1, (Fp)(-4.3f));
            QuaternionFp r2 = MathFp.slerp(test_q0, test_q1, (Fp)5.1f);

            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.2261014f, (Fp)0.8806396f, (Fp)(-0.3100654f), (Fp)0.2778693f),
                r0, (Fp)0.0001f);
            TestUtils.AreEqual(
                MathFp.QuaternionFp((Fp)(-0.4676181f), (Fp)(-0.5321988f), (Fp)(-0.3789966f), (Fp)(-0.5953646f)), r1,
                (Fp)0.0001f);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.2596942f, (Fp)(-0.4369303f), (Fp)0.7902023f, (Fp)0.34239f), r2,
                (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_mul_vector()
        {
            Fp3x3 m = TestMatrix.test3x3_xyz;
            QuaternionFp q = MathFp.QuaternionFp(m);

            Fp3 vector = MathFp.Fp3((Fp)1.1f, (Fp)(-2.2f), (Fp)3.5f);

            Fp3 mvector = MathFp.mul(m, vector);
            Fp3 qvector = MathFp.mul(q, vector);

            TestUtils.AreEqual(mvector, qvector, (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_log_exp_identity()
        {
            QuaternionFp q = MathFp.QuaternionFp((Fp)1.2f, (Fp)(-2.6f), (Fp)3.1f, (Fp)6.0f);
            QuaternionFp log_q = MathFp.log(q);
            QuaternionFp exp_log_q = MathFp.exp(log_q);
            TestUtils.AreEqual(q, exp_log_q, (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_log_exp_rotation()
        {
            QuaternionFp q = MathFp.QuaternionFp(TestMatrix.test3x3_xyz);
            QuaternionFp q3 = MathFp.mul(q, MathFp.mul(q, q));
            QuaternionFp log_q = MathFp.log(q);
            QuaternionFp t = MathFp.exp(MathFp.QuaternionFp(log_q.value * (Fp)3.0f));
            TestUtils.AreEqual(q3, t, (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_unitlog_unitexp_rotation()
        {
            QuaternionFp q = MathFp.QuaternionFp(TestMatrix.test3x3_xyz);
            QuaternionFp q3 = MathFp.mul(q, MathFp.mul(q, q));
            QuaternionFp log_q = MathFp.unitlog(q);
            QuaternionFp t = MathFp.unitexp(MathFp.QuaternionFp(log_q.value * (Fp)3.0f));
            TestUtils.AreEqual(q3, t, (Fp)0.0001f);
        }

        [TestCompiler]
        public static void quaternion_look_rotation()
        {
            // Exercise the 4 cases
            Fp3 forward0 = MathFp.normalize(MathFp.Fp3((Fp)1.0f, (Fp)2.0f, (Fp)3.0f));
            Fp3 up0 = MathFp.Fp3((Fp)0.0f, (Fp)1.0f, (Fp)0.0f);
            QuaternionFp q0 = QuaternionFp.LookRotation(forward0, up0);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.274657f), (Fp)0.153857f, (Fp)0.044571f, (Fp)0.948106f), q0,
                (Fp)0.001f);
            TestUtils.AreEqual(Fp3x3.LookRotation(forward0, up0), MathFp.Fp3x3(q0), (Fp)0.001f);

            Fp3 forward1 = MathFp.normalize(MathFp.Fp3((Fp)(-3.2f), (Fp)2.3f, (Fp)(-1.3f)));
            Fp3 up1 = MathFp.normalize(MathFp.Fp3((Fp)1.0f, (Fp)(-3.2f), (Fp)(-1.5f)));
            QuaternionFp q1 = QuaternionFp.LookRotation(forward1, up1);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.805418f, (Fp)0.089103f, (Fp)(-0.435327f), (Fp)(-0.392240f)),
                q1, (Fp)0.001f);
            TestUtils.AreEqual(Fp3x3.LookRotation(forward1, up1), MathFp.Fp3x3(q1), (Fp)0.001f);

            Fp3 forward2 = MathFp.normalize(MathFp.Fp3((Fp)(-2.6f), (Fp)(-5.2f), (Fp)(-1.1f)));
            Fp3 up2 = MathFp.normalize(MathFp.Fp3((Fp)(-4.2f), (Fp)(-1.2f), (Fp)(-4.5f)));
            QuaternionFp q2 = QuaternionFp.LookRotation(forward2, up2);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)(-0.088343f), (Fp)0.764951f, (Fp)(-0.534144f), (Fp)(-0.348907f)),
                q2, (Fp)0.001f);
            TestUtils.AreEqual(Fp3x3.LookRotation(forward2, up2), MathFp.Fp3x3(q2), (Fp)0.001f);

            Fp3 forward3 = MathFp.normalize(MathFp.Fp3((Fp)1.3f, (Fp)2.1f, (Fp)3.4f));
            Fp3 up3 = MathFp.normalize(MathFp.Fp3((Fp)0.2f, (Fp)(-1.0f), (Fp)0.3f));
            QuaternionFp q3 = QuaternionFp.LookRotation(forward3, up3);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.184984f, (Fp)0.247484f, (Fp)0.947425f, (Fp)(-0.083173f)), q3,
                (Fp)0.001f);
            TestUtils.AreEqual(Fp3x3.LookRotation(forward3, up3), MathFp.Fp3x3(q3), (Fp)0.001f);
        }

        [TestCompiler]
        public static void quaternion_look_rotation_safe()
        {
            Fp3 forward0 = MathFp.Fp3((Fp)(-3.2f), (Fp)2.3f, (Fp)(-1.3f)) * Fp.OneEMinus4;
            Fp3 up0 = MathFp.Fp3((Fp)1.0f, (Fp)(-3.2f), (Fp)(-1.5f)) * Fp.OneEMinus4;
            QuaternionFp q0 = QuaternionFp.LookRotationSafe(forward0, up0);
            TestUtils.AreEqual(MathFp.QuaternionFp((Fp)0.805418f, (Fp)0.089103f, (Fp)(-0.435327f), (Fp)(-0.392240f)),
                q0, (Fp)0.001f);

            Fp3 forward1 = MathFp.Fp3((Fp)(-3.2f), (Fp)2.3f, (Fp)(-1.3f)) * Fp.OneEMinus8;
            Fp3 up1 = MathFp.Fp3((Fp)1.0f, (Fp)(-3.2f), (Fp)(-1.5f));
            QuaternionFp q1 = QuaternionFp.LookRotationSafe(forward1, up1);
            TestUtils.AreEqual(QuaternionFp.Identity, q1, (Fp)0.001f);

            Fp3 forward2 = MathFp.Fp3((Fp)(-3.2f), (Fp)2.3f, (Fp)(-1.3f));
            Fp3 up2 = forward2;
            QuaternionFp q2 = QuaternionFp.LookRotationSafe(forward2, up2);
            TestUtils.AreEqual(QuaternionFp.Identity, q2, (Fp)0.001f);
        }
    }
}