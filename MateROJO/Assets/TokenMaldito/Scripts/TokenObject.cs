using UnityEngine;

public class TokenObject : MonoBehaviour
{
    public Material material;
    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;
    Vector3 [] vertex;
    int [] triangles;
    Vector3 posTemp;
    Vector3[] inicialPos;
    public float angle;
  

    void Start()
    {
       CreateBrujula();
    }
     private void Update()
    {
      TransformBrujula();  
    }

    void CreateBrujula()
    {
         meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        meshFilter.mesh = mesh;

        vertex = new[]
        {
              //Segunda Cara
                //1
                new Vector3(0,0,-1), // B-60  --0
                new Vector3(1,-6.32f,-1), //A1-61---1
                new Vector3(-0.9f,-6.3f,-1), // Z-62---2
                //2
                new Vector3(0,0,-1), // B-63
                new Vector3(2.82f,-5.75f,-1), //C1-64
                new Vector3(1,-6.32f,-1), //A1-65
                //3
                new Vector3(0,0,-1), // B-66
                new Vector3(4.37f,-4.65f,-1), // D1-67
                new Vector3(2.82f,-5.75f,-1), //C1-68
                //4
                new Vector3(0,0,-1), // B-69
                new Vector3(5.5f,-3.13f,-1), //E1-70
                new Vector3(4.37f,-4.65f,-1), //D1-71
                //5
                new Vector3(0,0,-1), // B-72
                new Vector3(6.11f,-1.32f,-1), //F1-73
                new Vector3(5.5f,-3.13f,-1), //E1-74
                //6
                new Vector3(0,0,-1), // B-75
                new Vector3(6.13f,0.58f,-1), //G1-76
                new Vector3(6.11f,-1.32f,-1), //F1-77
                //7
                new Vector3(0,0,-1), // B-78
                new Vector3(5.56f,2.39f,-1), // H1-79
                new Vector3(6.13f,0.58f,-1), //G1-80
                //8
                new Vector3(0,0,-1), // B-81
                new Vector3(4.46f,3.95f,-1), // I1-82
                new Vector3(5.56f,2.39f,-1), // H1-83
                //9
                new Vector3(0,0,-1), // B-84
                new Vector3(2.94f,5.08f,-1), // J1-85
                new Vector3(4.46f,3.95f,-1), // I1-86
                //10
                new Vector3(0,0,-1), // B-87
                new Vector3(1.14f,5.69f,-1), // K1-88
                new Vector3(2.94f,5.08f,-1), // J1-89
                //11
                new Vector3(0,0,-1), // B-90
                new Vector3(-0.77f,5.71f,-1), // l1-91
                new Vector3(1.14f,5.69f,-1), // K1-92
                //12
                new Vector3(0,0,-1), // B-93
                new Vector3(-2.58f,5.14f,-1), //M1-94
                new Vector3(-0.77f,5.71f,-1), // l1-95
                //13
                new Vector3(0,0,-1), // B-96
                new Vector3(-4.13f,4.04f,-1), //N1-97
                new Vector3(-2.58f,5.14f,-1), //M1-98
                //14
                new Vector3(0,0,-1), // B-99
                new Vector3(-5.27f,2.52f,-1), //O1-100
                new Vector3(-4.13f,4.04f,-1), //N1-101
                //15
                new Vector3(0,0,-1), // B-102
                new Vector3(-5.88f,0.71f,-1), //P1-103
                new Vector3(-5.27f,2.52f,-1), //O1-104
                //16
                new Vector3(0,0,-1), // B-105
                new Vector3(-5.9f,-1.19f,-1), //Q1-106
                new Vector3(-5.88f,0.71f,-1), //P1-107
                //17
                new Vector3(0,0,-1), // B-108
                new Vector3(-5.33f,-3,-1), //R1-109
                new Vector3(-5.9f,-1.19f,-1), //Q1-110
                //18
                new Vector3(0,0,-1), // B-111
                new Vector3(-4.23f,-4.56f,-1), //S1-112
                new Vector3(-5.33f,-3,-1), //R1-113
                //19
                new Vector3(0,0,-1), // B-114
                new Vector3(-2.7f,-5.69f,-1), //T1-115
                new Vector3(-4.23f,-4.56f,-1), //S1-116
                //20
                new Vector3(0,0,-1), // B-117
                new Vector3(-0.9f,-6.3f,-1), // Z-118
                new Vector3(-2.7f,-5.69f,-1), //T1-119
                

                //Bordes
                //1.1
                new Vector3(1,-6.32f,-1), //A1-120
                new Vector3(1,-6.32f,0), //E-121
                new Vector3(-0.9f,-6.3f,-1), // Z-122
                //2.1
                new Vector3(-0.77f,-6.39f,0), //D-123
                new Vector3(-0.9f,-6.3f,-1), // Z-124
                new Vector3(1,-6.32f,0), //E-125
                //3.2
                new Vector3(2.82f,-5.75f,-1), //C1-126
                new Vector3(2.82f,-5.75f,0), //F-127
                new Vector3(1,-6.32f,-1), //A1-128
                //4.2
                new Vector3(1,-6.32f,0), //E-129
                new Vector3(1,-6.32f,-1), //A1-130
                new Vector3(2.82f,-5.75f,0), //F-131
                //5.3
                new Vector3(4.37f,-4.65f,-1), //D1-132
                new Vector3(4.37f,-4.65f,0), // G-133
                new Vector3(2.82f,-5.75f,-1), //C1-134
                //6.3
                new Vector3(2.82f,-5.75f,0), //F-135
                new Vector3(2.82f,-5.75f,-1), //C1-136
                new Vector3(4.37f,-4.65f,0), // G-137
                //7.4
                new Vector3(5.5f,-3.13f,-1), //E1-138
                new Vector3(5.5f,-3.13f,0), //H-139
                new Vector3(4.37f,-4.65f,-1), //D1-140
                //8.4
                new Vector3(4.37f,-4.65f,0), // G-141
                new Vector3(4.37f,-4.65f,-1), //D1-142
                new Vector3(5.5f,-3.13f,0), //H-143
                //9.5
                new Vector3(6.11f,-1.32f,-1), //F1-144
                new Vector3(6.11f,-1.32f,0), //I-145
                new Vector3(5.5f,-3.13f,-1), //E1-146
               ///10.5
                new Vector3(5.5f,-3.13f,0), //H-147
                new Vector3(5.5f,-3.13f,-1), //E1-148
                new Vector3(6.11f,-1.32f,0), //I-149
                //11.6
                new Vector3(6.13f,0.58f,-1), //G1-150
                new Vector3(6.13f,0.58f,0), //J-151
                new Vector3(6.11f,-1.32f,-1), //F1-152
                //12.6
                new Vector3(6.11f,-1.32f,0), //I-153
                new Vector3(6.11f,-1.32f,-1), //F1-154
                new Vector3(6.13f,0.58f,0), //J-155
                //13.7
                new Vector3(5.56f,2.39f,-1), // H1-156
                new Vector3(5.56f,2.39f,0), //K-157
                new Vector3(6.13f,0.58f,-1), //G1-158
                //14.7
                new Vector3(6.13f,0.58f,0), //J-159
                new Vector3(6.13f,0.58f,-1), //G1-160
                new Vector3(5.56f,2.39f,0), //K-161
                //15.8
                new Vector3(4.46f,3.95f,-1), // I1-162
                new Vector3(4.46f,3.95f,0), //L-163
                new Vector3(5.56f,2.39f,-1), // H1-164
               ///16.8
                new Vector3(5.56f,2.39f,0), //K-165
                new Vector3(5.56f,2.39f,-1), // H1-166
                new Vector3(4.46f,3.95f,0), //L-167
                //17.9
                new Vector3(2.94f,5.08f,-1), // J1-168
                new Vector3(2.94f,5.08f,0), //M-169
                new Vector3(4.46f,3.95f,-1), // I1-170
                //18.9
                new Vector3(4.46f,3.95f,0), //L-171
                new Vector3(4.46f,3.95f,-1), // I1-172
                new Vector3(2.94f,5.08f,0), //M-173
                //19.10
                new Vector3(1.14f,5.69f,-1), // K1-174
                new Vector3(1.14f,5.69f,0), //N-175
                new Vector3(2.94f,5.08f,-1), // J1-1176
                //20.10
                new Vector3(2.94f,5.08f,0), //M-177
                new Vector3(2.94f,5.08f,-1), // J1-178
                new Vector3(1.14f,5.69f,0), //N-179
                //21.11
                new Vector3(-0.77f,5.71f,-1), // l1-180
                new Vector3(-0.77f,5.71f,0), //O-181
                new Vector3(1.14f,5.69f,-1), // K1-182
                //22.11
                new Vector3(1.14f,5.69f,0), //N-183
                new Vector3(1.14f,5.69f,-1), // K1-184
                new Vector3(-0.77f,5.71f,0), //O-185
                //23.12
                new Vector3(-2.58f,5.14f,-1), //M1-186
                new Vector3(-2.58f,5.14f,0), //P-187
                new Vector3(-0.77f,5.71f,-1), // l1-188
                //24.12
                new Vector3(-0.77f,5.71f,0), //O-189
                new Vector3(-0.77f,5.71f,-1), // l1-190
                new Vector3(-2.58f,5.14f,0), //P-191
                //25.13
                new Vector3(-4.13f,4.04f,-1), //N1-192
                new Vector3(-4.13f,4.04f,0), // Q-193
                new Vector3(-2.58f,5.14f,-1), //M1-194
                //26.13
                new Vector3(-2.58f,5.14f,0), //P-195
                new Vector3(-2.58f,5.14f,-1), //M1-196
                new Vector3(-4.13f,4.04f,0), // Q-197
                //27.14
                new Vector3(-5.27f,2.52f,-1), //O1-198
                new Vector3(-5.27f,2.52f,0), // R-199
                new Vector3(-4.13f,4.04f,-1), //N1-200
                //38.14
                new Vector3(-4.13f,4.04f,0), // Q-201
                new Vector3(-4.13f,4.04f,-1), //N1-202
                new Vector3(-5.27f,2.52f,0), // R-203
                //39.15
                new Vector3(-5.88f,0.71f,-1), //P1-204
                new Vector3(-5.88f,0.71f,0), // S-205
                new Vector3(-5.27f,2.52f,-1), //O1-206
                //40.15
                new Vector3(-5.27f,2.52f,0), // R-207
                new Vector3(-5.27f,2.52f,-1), //O1-208
                new Vector3(-5.88f,0.71f,0), // S-209
                //42.16
                new Vector3(-5.9f,-1.19f,-1), //Q1-210
                new Vector3(-5.9f,-1.19f,0), // T-211
                new Vector3(-5.88f,0.71f,-1), //P1-212
                //43.16
                new Vector3(-5.88f,0.71f,0), // S-213
                new Vector3(-5.88f,0.71f,-1), //P1-215
                new Vector3(-5.9f,-1.19f,0), // T-214
                //44.17
                new Vector3(-5.33f,-3,-1), //R1-216
                new Vector3(-5.33f,-3,0), // U-217
                new Vector3(-5.9f,-1.19f,-1), //Q1-218
                //45.17
                new Vector3(-5.9f,-1.19f,0), // T-219
                new Vector3(-5.9f,-1.19f,-1), //Q1-220
                new Vector3(-5.33f,-3,0), // U-221
                //46.18
                new Vector3(-4.23f,-4.56f,-1), //S1-222
                new Vector3(-4.23f,-4.56f,0), // V-223
                new Vector3(-5.33f,-3,-1), //R1-224
                //47.18
                new Vector3(-5.33f,-3,0), // U-225
                new Vector3(-5.33f,-3,-1), //R1-226
                new Vector3(-4.23f,-4.56f,0), // V-227
                //48.19
                new Vector3(-2.7f,-5.69f,-1), //T1-228
                new Vector3(-2.7f,-5.69f,0), // W-229
                new Vector3(-4.23f,-4.56f,-1), //S1-230
                //49.19
                new Vector3(-4.23f,-4.56f,0), // V-231
                new Vector3(-4.23f,-4.56f,-1), //S1-232
                new Vector3(-2.7f,-5.69f,0), // W-233
                //50.20
                new Vector3(-0.9f,-6.3f,-1), // Z-234
                new Vector3(-0.77f,-6.39f,0), //D-235
                new Vector3(-2.7f,-5.69f,-1), //T1-236
                //51.21
                new Vector3(-2.7f,-5.69f,0), // W-237
                new Vector3(-2.7f,-5.69f,-1), //T1-238
                new Vector3(-0.77f,-6.39f,0), //D-239
                
        };

        meshFilter.mesh.vertices = vertex;
        
        int [] triangles = 
        {
            //Primera Cara -----SegundaCara
            0,1,2, //1
            3,4,5, //2
            6,7,8, //3
            9,10,11, //4
            12,13,14,//5
            15,16,17,//6
            18,19,20,//7
            21,22,23,//8
            24,25,26,//9
            27,28,29,//10
            30,31,32,//11
            33,34,35,//12
            36,37,38,//13
            39,40,41,//14
            42,43,44,//15
            45,46,47,//16
            48,49,50,//17
            51,52,53,//18
            54,55,56,//19
            57,58,59,//20
            //Segunda Cara
            60,61,62, //21
            63,64,65, //22
            66,67,68, //23
            69,70,71, //24
            72,73,74, //25
            75,76,77,//26
            78,79,80,//27
            81,82,83,//28
            84,85,86,//29
            87,88,89,//30
            90,91,92,//31
            93,94,95,//32
            96,97,98,//33
            99,100,101,//34
            102,103,104,//35
            105,106,107,//36
            108,109,110,//37
            111,112,113,//38
            114,115,116,//39
            117,118,119,//40
            //Bordes
            120,121,122,//41
            123,124,125, //42
            126,127,128,//43
            129,130,131, // 44
            132,133,134, //45
            135,136,137, //47
            138,139,140, //48
            141,142,143, //49
            144,145,146,//50
            147,148,149, //51
            150,151,152, //52
            153,154,155, //53
            156,157,158,//54
            159,160,161, //55
            162,163,164,//56
            165,166,167, //57
            168,169,170,//58
            171,172,173,//59
            174,175,176,//60
            177,178,179,//61
           
        };
    
        Vector2[] uvs =
        {
           
            //SegundaCara
            //1
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.58f,0.498f),//a1
            new Vector2(0.414f,0.498f),//z1
            //2
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.725f,0.472f),//c0
            new Vector2(0.58f,0.498f),//a1
            //3
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.844f,0.427f),//d0
            new Vector2(0.725f,0.472f),//c0
            //4
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.929f,0.364f),//e0
            new Vector2(0.844f,0.427f),//d0
            //5
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.97f,0.29f),//f0
            new Vector2(0.929f,0.364f),//e0
            //6
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.975f,0.216f),//g0
            new Vector2(0.978f,0.293f),//f0
            //7
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.929f,0.146f),//h0
            new Vector2(0.975f,0.216f),//g0
            //8
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.84f,0.084f),//i0
            new Vector2(0.929f,0.146f),//h0
            //9
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.72f,0.0391f),//j0
            new Vector2(0.84f,0.084f),//i0
            //10
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.576f,0.013f),//k0
            new Vector2(0.72f,0.0391f),//j0
            //11
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.42f,0.012f),//l0
            new Vector2(0.576f,0.013f),//k0
            //12
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.27f,0.034f),//m0
            new Vector2(0.42f,0.012f),//l0
            //13
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.14f,0.079f),//n0
            new Vector2(0.27f,0.034f),//m0
            //14
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.057f,0.14f),//o0
            new Vector2(0.14f,0.079f),//n0
            //15
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.009f,0.21f),//p0
            new Vector2(0.057f,0.14f),//o0
            //16
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.009f,0.29f),//q0
            new Vector2(0.009f,0.21f),//p0
            //17
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.05f,0.36f),//r0
            new Vector2(0.009f,0.29f),//q0
            //18
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.14f,0.42f),//s0
            new Vector2(0.05f,0.36f),//r0
            //19
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.26f,0.47f),//t0
            new Vector2(0.14f,0.42f),//s0
            //20
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.414f,0.498f),//z0
            new Vector2(0.26f,0.47f),//t0
            
            //Bordes
            //1.1
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //2.1
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //3.2
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //4.2
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //5.3
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //6.3
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //7.4
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //8.4
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //9.5
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //10.5
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //11.6
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //12.6
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //13.7
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //14.7
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //15.8
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //16.8
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //17.9
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //18.9
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //19.10
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //20.10
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //21.11
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //22.11
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //23.12
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //24.12
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //25.13
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0   
            //26.13
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //27.14
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //28.14
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //29.15 
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //30.15 
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //31.16
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //32.16
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //33.17
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //34.17
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //35.18
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //36.18
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //37.19
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //38.19
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //39.20
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //40.20
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
        };
     
        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;   
    }
    

  void TransformBrujula()
  {
     Mesh mesh = GetComponent<MeshFilter>().mesh;
    meshFilter.mesh = mesh;
    posTemp = this.transform.position;
    this.transform.position = new Vector3 (0,0,0);

    for(int i = 0; i< vertex.Length; i++)
    {
             if(Input.GetKeyDown(KeyCode.X))
             vertex[i] = RotateX(vertex[i].x,vertex[i].y,vertex[i].z);
             if(Input.GetKeyDown(KeyCode.Y))
             vertex[i] = RotateY(vertex[i].x,vertex[i].y,vertex[i].z);
             if(Input.GetKeyDown(KeyCode.Z))
              vertex[i] = RotateZ(vertex[i].x,vertex[i].y,vertex[i].z);
            
     }    

        meshFilter.mesh.vertices = vertex;
        
        int [] triangles = 
        {
            //Primera Cara -----SegundaCara
            0,1,2, //1
            3,4,5, //2
            6,7,8, //3
            9,10,11, //4
            12,13,14,//5
            15,16,17,//6
            18,19,20,//7
            21,22,23,//8
            24,25,26,//9
            27,28,29,//10
            30,31,32,//11
            33,34,35,//12
            36,37,38,//13
            39,40,41,//14
            42,43,44,//15
            45,46,47,//16
            48,49,50,//17
            51,52,53,//18
            54,55,56,//19
            57,58,59,//20
            //Segunda Cara
            60,61,62, //21
            63,64,65, //22
            66,67,68, //23
            69,70,71, //24
            72,73,74, //25
            75,76,77,//26
            78,79,80,//27
            81,82,83,//28
            84,85,86,//29
            87,88,89,//30
            90,91,92,//31
            93,94,95,//32
            96,97,98,//33
            99,100,101,//34
            102,103,104,//35
            105,106,107,//36
            108,109,110,//37
            111,112,113,//38
            114,115,116,//39
            117,118,119,//40
            //Bordes
            120,121,122,//41
            123,124,125, //42
            126,127,128,//43
            129,130,131, // 44
            132,133,134, //45
            135,136,137, //47
            138,139,140, //48
            141,142,143, //49
            144,145,146,//50
            147,148,149, //51
            150,151,152, //52
            153,154,155, //53
            156,157,158,//54
            159,160,161, //55
            162,163,164,//56
            165,166,167, //57
            168,169,170,//58
            171,172,173,//59
            174,175,176,//60
            177,178,179,//61
           
        };
    
        Vector2[] uvs =
        {
           
            //SegundaCara
            //1
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.58f,0.498f),//a1
            new Vector2(0.414f,0.498f),//z1
            //2
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.725f,0.472f),//c0
            new Vector2(0.58f,0.498f),//a1
            //3
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.844f,0.427f),//d0
            new Vector2(0.725f,0.472f),//c0
            //4
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.929f,0.364f),//e0
            new Vector2(0.844f,0.427f),//d0
            //5
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.97f,0.29f),//f0
            new Vector2(0.929f,0.364f),//e0
            //6
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.975f,0.216f),//g0
            new Vector2(0.978f,0.293f),//f0
            //7
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.929f,0.146f),//h0
            new Vector2(0.975f,0.216f),//g0
            //8
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.84f,0.084f),//i0
            new Vector2(0.929f,0.146f),//h0
            //9
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.72f,0.0391f),//j0
            new Vector2(0.84f,0.084f),//i0
            //10
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.576f,0.013f),//k0
            new Vector2(0.72f,0.0391f),//j0
            //11
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.42f,0.012f),//l0
            new Vector2(0.576f,0.013f),//k0
            //12
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.27f,0.034f),//m0
            new Vector2(0.42f,0.012f),//l0
            //13
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.14f,0.079f),//n0
            new Vector2(0.27f,0.034f),//m0
            //14
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.057f,0.14f),//o0
            new Vector2(0.14f,0.079f),//n0
            //15
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.009f,0.21f),//p0
            new Vector2(0.057f,0.14f),//o0
            //16
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.009f,0.29f),//q0
            new Vector2(0.009f,0.21f),//p0
            //17
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.05f,0.36f),//r0
            new Vector2(0.009f,0.29f),//q0
            //18
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.14f,0.42f),//s0
            new Vector2(0.05f,0.36f),//r0
            //19
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.26f,0.47f),//t0
            new Vector2(0.14f,0.42f),//s0
            //20
            new Vector2(0.5f,0.25f),//b0
            new Vector2(0.414f,0.498f),//z0
            new Vector2(0.26f,0.47f),//t0
            
            //Bordes
            //1.1
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //2.1
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //3.2
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //4.2
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //5.3
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //6.3
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //7.4
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //8.4
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //9.5
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //10.5
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //11.6
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //12.6
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //13.7
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //14.7
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //15.8
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //16.8
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //17.9
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //18.9
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //19.10
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //20.10
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //21.11
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //22.11
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //23.12
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //24.12
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //25.13
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0   
            //26.13
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //27.14
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //28.14
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //29.15 
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //30.15 
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //31.16
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //32.16
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //33.17
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //34.17
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //35.18
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //36.18
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //37.19
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //38.19
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //39.20
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
            //40.20
            new Vector2(0.83f,0.47f),//b0
            new Vector2(0.98f,0.54f),//b0
            new Vector2(0.83f,0.54f),//b0
        };
     
        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;  
        this.transform.position =  posTemp; 
  }




Vector3 RotateX(float x,float y, float z)
    {
        Vector3 pos = new Vector3(x,y,z);
        float yPrima = ((pos.y * Mathf.Cos(angle)) - (pos.z * Mathf.Sin(angle)));
        float zPrima = ((pos.y * Mathf.Sin(angle)) + (pos.z * Mathf.Cos(angle)));
        
        return new Vector3(pos.x,yPrima,zPrima);
    }

    Vector3 RotateY(float x, float y, float z)
    {
        Vector3 pos = new Vector3(x,y,z);
        float zPrima = (pos.z * Mathf.Cos(angle)) - (pos.x * Mathf.Sin(angle));
        float xPrima = (pos.z * Mathf.Sin(angle)) + (pos.x * Mathf.Cos(angle));

        return new Vector3(xPrima, pos.y,zPrima);
    }
    Vector3 RotateZ(float x, float y, float z)
    {  
        Vector3 pos = new Vector3(x,y,z);
        float xPrima = (pos.x * Mathf.Cos(angle)) - (pos.y * Mathf.Sin(angle));
        float yPrima = (pos.x * Mathf.Sin(angle)) + (pos.y * Mathf.Cos(angle));

        return new Vector3(xPrima,yPrima,pos.z);

    }
    





}
