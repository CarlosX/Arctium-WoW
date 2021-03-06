﻿/*
 * Copyright (C) 2012-2014 Arctium Emulation <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Framework.Network.Packets;

namespace Framework.Packets.Client.Authentication
{
    public class AuthContinuedSession : IClientPacket
    {
        public ulong DosResponse { get; set; }
        public ulong Key         { get; set; }
        public byte[] Digest     { get; set; }

        public override IClientPacket Read()
        {
            DosResponse = Packet.Read<ulong>();
            Key         = Packet.Read<ulong>();
            Digest      = Packet.ReadBytes(20);

            return this;
        }
    }
}
