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

namespace Framework.Packets.Client.Net
{
    public class SuspendCommsAck : IClientPacket
    {
        public uint Serial    { get; set; }
        public uint Timestamp { get; set; }

        public override IClientPacket Read()
        {
            Serial    = Packet.Read<uint>();
            Timestamp = Packet.Read<uint>();

            return this;
        }
    }
}
