// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/TImeSlotService.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace sep3client.timeslot {
  public static partial class TimeSlotService
  {
    static readonly string __ServiceName = "sep3datalayer.grpc.protobuf.TimeSlotService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sep3client.timeslot.CreatingTimeSlot> __Marshaller_sep3datalayer_grpc_protobuf_CreatingTimeSlot = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sep3client.timeslot.CreatingTimeSlot.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::sep3client.timeslot.TimeSlotGrpc> __Marshaller_sep3datalayer_grpc_protobuf_TimeSlotGrpc = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::sep3client.timeslot.TimeSlotGrpc.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::sep3client.timeslot.CreatingTimeSlot, global::sep3client.timeslot.TimeSlotGrpc> __Method_CreateTimeSlot = new grpc::Method<global::sep3client.timeslot.CreatingTimeSlot, global::sep3client.timeslot.TimeSlotGrpc>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateTimeSlot",
        __Marshaller_sep3datalayer_grpc_protobuf_CreatingTimeSlot,
        __Marshaller_sep3datalayer_grpc_protobuf_TimeSlotGrpc);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::sep3client.timeslot.TImeSlotServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TimeSlotService</summary>
    [grpc::BindServiceMethod(typeof(TimeSlotService), "BindService")]
    public abstract partial class TimeSlotServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::sep3client.timeslot.TimeSlotGrpc> CreateTimeSlot(global::sep3client.timeslot.CreatingTimeSlot request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TimeSlotService</summary>
    public partial class TimeSlotServiceClient : grpc::ClientBase<TimeSlotServiceClient>
    {
      /// <summary>Creates a new client for TimeSlotService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TimeSlotServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TimeSlotService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TimeSlotServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TimeSlotServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TimeSlotServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::sep3client.timeslot.TimeSlotGrpc CreateTimeSlot(global::sep3client.timeslot.CreatingTimeSlot request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateTimeSlot(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::sep3client.timeslot.TimeSlotGrpc CreateTimeSlot(global::sep3client.timeslot.CreatingTimeSlot request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateTimeSlot, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::sep3client.timeslot.TimeSlotGrpc> CreateTimeSlotAsync(global::sep3client.timeslot.CreatingTimeSlot request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateTimeSlotAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::sep3client.timeslot.TimeSlotGrpc> CreateTimeSlotAsync(global::sep3client.timeslot.CreatingTimeSlot request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateTimeSlot, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override TimeSlotServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TimeSlotServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TimeSlotServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateTimeSlot, serviceImpl.CreateTimeSlot).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TimeSlotServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateTimeSlot, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::sep3client.timeslot.CreatingTimeSlot, global::sep3client.timeslot.TimeSlotGrpc>(serviceImpl.CreateTimeSlot));
    }

  }
}
#endregion